package com.disneystreaming.i21;

import java.time.ZonedDateTime;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.stream.Collectors;

import com.fasterxml.jackson.annotation.JsonProperty;

/**
 * This is the core of the test, implement the method {@link #getTopTitles(String, String, String)}.
 *
 * Consider using the utility methods in {@link JsonConverters}.
 */
final class TopTitlesService {

    private TopTitlesService() {
    }

    /**
     * Implements the top titles selection algorithm, see <code>README.md</code> for details. See
     * <code>test/java/.../TopTitlesServiceTest</code> to verify your implementation.
     *
     * The JSON parsing and conversion is available in {@link JsonConverters#convertContentData(String)} and
     * {@link JsonConverters#convertPreferences(String)}.
     *
     * @param contentDataJson the JSON data of an array of {@link Content}, i.e. <code>"[{...}, {...}, ...]"</code>
     * @param brandPreferencesJson the JSON data of a dictionary, where the keys and values represent the user's <em>brand preferences</em>
     * @param contentTypePreferencesJson the JSON data of a dictionary, where the keys and values represent the user's <em>content type preferences</em>
     * @return the top titles
     */
    static List<String> getTopTitles(String contentDataJson, String brandPreferencesJson, String contentTypePreferencesJson) {    	
    	int totalScore = 0;    	
    	ZonedDateTime available = ZonedDateTime.parse("2020-01-01T00:00:00+00:00");
 
    	//convert contentDataJson to list - Preferably convert all incoming data to 3 lists for convenience.
    	List <Content> contentData = JsonConverters.convertContentData(contentDataJson);
    	Map <String, String> contentPreferences = JsonConverters.convertPreferences(contentTypePreferencesJson);
    	Map <String, String> brandPreferences = JsonConverters.convertPreferences(brandPreferencesJson);
    	
    	//Applying preference values.
    	HashMap<String,Integer> preferences = new HashMap<>();  
    	preferences.put("dislike", -20);
    	preferences.put("indifferent", 0);
    	preferences.put("like", 10);
    	preferences.put("adore", 30);
    	preferences.put("love", 50);

    	List<Result> finalResult = new ArrayList<Result>();
    	
    	
    	//Once converted into a list, extract all data that is available in US and before 01/01/2020 as per the README.md
    	//Then, loop through the list and calculate the popularity score
    	for(Content record:contentData) {
    		if(record.getAvailability().contains("US"))
    		{
    			if(record.getAvailableDate().isBefore(available))	
    			{
    				String brand = record.getBrand();
    				String type = record.getContentType();
    				totalScore = record.getPopularityScore();
    				
    				if(brandPreferences.containsKey(brand))
    				{
    				 totalScore += preferences.get(brandPreferences.get(brand));
    				}
    				
    				if(contentPreferences.containsKey(type))
    				{
    				 totalScore += preferences.get(contentPreferences.get(type));
    				}
    				            
    				Result finalOutput = new Result();
    				finalOutput.setTitle(record.getTitle());
    				finalOutput.setFinalScore(totalScore);
    				
    				finalResult.add(finalOutput);
    			}
    		}
    	}
    	
    	
    	//Once score is assigned, sort the list by popularity, and then alphabetically via name. - 
    	//Returning only top 5, if any less, return all.
    	Collections.sort(finalResult, Comparator.comparing(Result::getFinalScore).thenComparing(Result::getTitle));
    	Collections.reverse(finalResult);
    	List<Result> finalList = finalResult.stream().limit(5).collect(Collectors.toList());
    	
    	//to test output
    	/*Iterator<Result> print = finalList.iterator();
    	while(print.hasNext())
    	{
    		Result printValue = print.next();
    		System.out.print(printValue.getTitle() + " " + printValue.getFinalScore() + "\n");	
    	}*/

    	
    	//Apply to List to return
    	List<String> results = new ArrayList<String>();
    	for(Result test : finalList)
    	{
    		results.add(test.getTitle());
    	}
    	
    	
    	return results;

    }

}





