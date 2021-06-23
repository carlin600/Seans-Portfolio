package com.disneystreaming.i21;

import com.fasterxml.jackson.core.type.TypeReference;
import com.fasterxml.jackson.databind.ObjectMapper;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.util.List;

class TestResourceData {
    private final String contentData;
    private final String brandPreferences;
    private final String contentTypePreferences;
    private final List<String> expectedResult;

    public TestResourceData(String contentData, String brandPreferences, String contentTypePreferences, List<String> expectedResult) {
        this.contentData = contentData;
        this.brandPreferences = brandPreferences;
        this.contentTypePreferences = contentTypePreferences;
        this.expectedResult = expectedResult;
    }

    static TestResourceData fromResource(int number) throws IOException {
        InputStream in = TestResourceData.class.getResourceAsStream("/input" + number + ".txt");
        assert (in != null);
        BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(in));

        String contentData = bufferedReader.readLine();
        String brandPreferences = bufferedReader.readLine();
        String contentTypePreferences = bufferedReader.readLine();
        String expectedLine = bufferedReader.readLine();
        List<String> expectedResult = new ObjectMapper().readValue(expectedLine, new TypeReference<>() {
        });
        return new TestResourceData(contentData, brandPreferences, contentTypePreferences, expectedResult);
    }

    String getContentData() {
        return contentData;
    }

    String getBrandPreferences() {
        return brandPreferences;
    }

    String getContentTypePreferences() {
        return contentTypePreferences;
    }

    List<String> getExpectedResult() {
        return expectedResult;
    }
}
