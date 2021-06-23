# Instructions
This project includes a basic Maven project with a `TopTitlesService.java` that contains the code for you to complete; 
the codebase comes with some example input and expected output, you can run the unit test in `TopTitlesServiceTest.java` to verify your implementation.

We have no explicit performance or memory footprint requirements for the implementation; however, at the very least, it should work according to the following specification. 
We encourage you to consider as many strange scenarios as possible: unusual input, malicious input, etc.

The basic setup is to uncompress all source files and then verify that the project can be built using [Maven](https://maven.apache.org). If you don't already have Maven installed you can find install instructions 

[here](https://maven.apache.org/install.html), or install it using Homebrew (Mac) or Chocolatey (Windows) if you prefer:

```shell
brew install maven    # Install using Homebrew, for Mac users
choco install maven   # Install using Chocolatey, for Windows users
```

```
project-dir> $ mvn compile
[INFO] Scanning for projects...
[INFO]
[INFO] -----------------< com.disneystreaming:internship2021 >-----------------
[INFO] Building internship2021 1.0
[INFO] --------------------------------[ jar ]---------------------------------
[INFO]
[INFO] --- maven-resources-plugin:2.6:resources (default-resources) @ internship2021 ---
[INFO] Using 'UTF-8' encoding to copy filtered resources.
[INFO] skip non existing resourceDirectory /project-dir/java/src/main/resources
[INFO]
[INFO] --- maven-compiler-plugin:3.1:compile (default-compile) @ internship2021 ---
[INFO] Nothing to compile - all classes are up to date
[INFO] ------------------------------------------------------------------------
[INFO] BUILD SUCCESS
[INFO] ------------------------------------------------------------------------
[INFO] Total time:  0.518 s
[INFO] Finished at: 2021-05-18T12:53:51+01:00
[INFO] ------------------------------------------------------------------------
```

However, since the implementation is missing, running tests should result in a test failure.


```
project-dir> $ mvn test
[INFO] Scanning for projects...
...
[INFO] -------------------------------------------------------
[INFO]  T E S T S
[INFO] -------------------------------------------------------
[INFO] Running com.disneystreaming.i21.TopTitlesServiceTest
[ERROR] Tests run: 1, Failures: 1, Errors: 0, Skipped: 0, Time elapsed: 0.186 s <<< FAILURE! - in com.disneystreaming.i21.TopTitlesServiceTest
[ERROR] resourceBased  Time elapsed: 0.18 s  <<< FAILURE!
org.opentest4j.AssertionFailedError: Test case 0 ==> array lengths differ, expected: <0> but was: <5>
	at com.disneystreaming.i21.TopTitlesServiceTest.resourceBased(TopTitlesServiceTest.java:17)

[INFO]
[INFO] Results:
[INFO]
[ERROR] Failures:
[ERROR]   TopTitlesServiceTest.resourceBased:17 Test case 0 ==> array lengths differ, expected: <0> but was: <5>
[INFO]
[ERROR] Tests run: 1, Failures: 1, Errors: 0, Skipped: 0
[INFO]
[INFO] ------------------------------------------------------------------------
[INFO] BUILD FAILURE
[INFO] ------------------------------------------------------------------------
[INFO] Total time:  2.145 s
[INFO] Finished at: 2021-05-18T12:58:47+01:00
[INFO] ------------------------------------------------------------------------
...
```

You may refactor the code in any way you wish, add as many tests as you wish. 
The only requirement is that the method `com.disneystreaming.i21.TopTitlesService.getTopTitles` must remains and its return type and parameters remain intact. 
You should also not add any additional dependencies or settings to `pom.xml`.

```java
package com.disneystreaming.i21;

import java.util.List;

final class TopTitlesService {

    static List<String> getTopTitles(String contentDataJson, String brandPreferencesJson, String contentTypePreferencesJson) {
        ...
    }

}
```

You can use your preferred IDE, but we will use the Maven automated build to assess your code; therefore, before submitting your solution--even if your solution fails some tests--you should check that your code _compiles_ 
using `mvn test`. We will not be able to consider code that fails to compile.

# Requirements
We want Disney+ users to be able to find content that they are excited to watch and is most relevant to them. That means displaying some titles that we recommend based on their interests and watching habits.

For this challenge, we will provide you a list of content data. 
Each piece of content has information about its availability (countries and date available) and specific details such as title, brand, type of content, and a popularity score. 
For example:

```json
{
    "title": "Toy Story 3",
    "brand": "Pixar",
    "availability": ["CA", "FR", "US"],
    "availableDate": "2019-11-12T05:00:00.000Z",
    "popularityScore": 98,
    "contentType": "movie"
}
```

Note that the `availableDate` field is in JSON Date Format--ISO8601 `YYYY-MM-DDThh:mm:ss.sZ`.

Two sets of user preferences will be provided based on the `brand` and `contentType` attributes of a piece of content. 
The preferences keys will be possible values for the attribute (e.g. "Pixar" for `brand`) and the values are `String`s corresponding to the user preference adjustments.

## Preference Adjustments:
- dislike (-20)
- indifferent (+0)
- like (+10)
- adore (+30)
- love (+50)

For example, using the _Toy Story 3_ as an example, and the following brand and content type prefereces

`brand`
```json
{
  "Star Wars": "love",
  "Disney": "like",
  "Marvel": "dislike",
  "Pixar": "dislike"
}
```

`contentType`
```json
{
  "movie": "love",
  "series": "like",
  "short": "dislike"
}
```

we would calculate _Toy Story 3_'s final score as `128` = `98` (_base score_) `- 20` (_dislike_ the _Pixar_ brand) `+ 50` (_love_ the content type _movie_). If a key is missing from the dictionary, assume the value is "indifferent". 
For example, the `contentType` preferences could just be `{ "movie": "like" }` or even `{}`.

## Your Task
Implement the method `com.disneystreaming.i21.TopTitlesService.getTopTitles` which will:

- Calculate the overall score for each piece of content using the `popularityScore` as a base and adding or subtracting points based on the user's preferences.
- The content must be available in the US and available on or before 01/01/2020 to receive a score. In the example above, "Toy Story 3" would receive an overall score of 128.
- Return a `List<String>` of the content titles that have the top 5 scores (sorted from highest to lowest score), are available in the US, and are available on or before 01/01/2020.
- If there is a tie, sort content alphabetically by content title.
- If there are fewer than 5 titles, return all titles sorted by score.
- If a preference value is missing, assume the user is "indifferent" and add 0.

You are also encouraged to consider unusual input parameters and error handling.

_Note: all content data was created for the purpose of this challenge. Popularity scores, availability countries and availability dates do not reflect real Disney data._
