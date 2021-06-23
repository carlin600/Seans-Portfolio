package com.disneystreaming.i21;

import org.junit.jupiter.api.Test;

import java.io.IOException;
import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

public class TopTitlesServiceTest {

    private void resourceBased(int testCase) throws IOException {
        final TestResourceData rd = TestResourceData.fromResource(testCase);
        final List<String> result = TopTitlesService.getTopTitles(rd.getContentData(), rd.getBrandPreferences(),
                rd.getContentTypePreferences());
        
        assertArrayEquals(rd.getExpectedResult().toArray(), result.toArray(), "Test case " + testCase);
    }

    @Test
    void testInput0() throws IOException {
        resourceBased(0);
    }

    @Test
    void testInput1() throws IOException {
        resourceBased(1);
    }

    @Test
    void testInput4() throws IOException {
        resourceBased(4);
    }

    @Test
    void testInput5() throws IOException {
        resourceBased(5);
    }

    @Test
    void testInput6() throws IOException {
        resourceBased(6);
    }

    @Test
    void testInput7() throws IOException {
        resourceBased(7);
    }

    @Test
    void testInput8() throws IOException {
        resourceBased(8);
    }

    @Test
    void testInput10() throws IOException {
        resourceBased(10);
    }
}
