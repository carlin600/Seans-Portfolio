package com.disneystreaming.i21;

import com.fasterxml.jackson.annotation.JsonProperty;

import java.time.ZonedDateTime;
import java.util.List;

/**
 * Represents a piece of content. See `README.md` for description of the fields.
 */
class Content {
    private String title;
    private String brand;
    private List<String> availability;
    private ZonedDateTime availableDate;
    @JsonProperty(value="isKidsContent")
    private boolean isKidsContent;
    private int popularityScore;
    private String contentType;

    public String getTitle() {
        return this.title;
    }
    public String getBrand() {
        return this.brand;
    }
    public List<String> getAvailability() {
        return this.availability;
    }
    public ZonedDateTime getAvailableDate() {
        return this.availableDate;
    }
    public int getPopularityScore() {
        return this.popularityScore;
    }
    public String getContentType()  {
        return this.contentType;
    }
    public boolean isKidsContent() {
        return isKidsContent;
    }
}
