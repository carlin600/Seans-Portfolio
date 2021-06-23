package com.disneystreaming.i21;

import com.fasterxml.jackson.core.JsonProcessingException;
import com.fasterxml.jackson.core.type.TypeReference;
import com.fasterxml.jackson.databind.ObjectMapper;
import com.fasterxml.jackson.datatype.jsr310.JavaTimeModule;

import java.util.List;
import java.util.Map;

/**
 * This class contains convenience methods that convert strings that should be valid
 * JSON content to the appropriate types.
 */
final class JsonConverters {

    private JsonConverters() {}
    private static final ObjectMapper objectMapper = new ObjectMapper().registerModule(new JavaTimeModule());

    /**
     * Converts the preferences JSON dictionary to Java <code>Map&lt;String, String&gt;</code>, for example
     * the JSON
     *
     * <code><pre>
     * {
     *      "foo":"one",
     *      "bar":"two"
     * }
     * </pre></code>
     *
     * This method will return the map containing the keys <code>"foo"</code> and <code>"bar"</code>, with
     * values <code>"one"</code> and <code>"two"</code>.
     *
     * @param preferences the contents of a JSON dictionary
     * @return the converted map
     * @throws JsonDecodeException if the JSON document cannot be decoded
     */
    public static Map<String, String> convertPreferences(final String preferencesData) {
        try {
            return objectMapper.readValue(preferencesData, new TypeReference<>() { });
        } catch (JsonProcessingException e) {
            throw new JsonDecodeException(e);
        }
    }

    /**
     * Converts the contentData containing JSON array of elements that can be converted to
     * <code>Content</code> values. Note that this method performs no additional validation,
     * as long as the <code>contentData</code> is an array of JSON document where every element
     * can be decoded to the <code>Content</code> instance, this method will succeed.
     *
     * @param contentData the contents of a JSON array containing <code>Content</code> objects
     * @return the converted list
     * @throws JsonDecodeException if the JSON document cannot be decoded
     */
    public static List<Content> convertContentData(final String contentData) {
        try {
            return objectMapper.readValue(contentData, new TypeReference<>(){});
        } catch (JsonProcessingException e) {
            throw new JsonDecodeException(e);
        }
    }

}
