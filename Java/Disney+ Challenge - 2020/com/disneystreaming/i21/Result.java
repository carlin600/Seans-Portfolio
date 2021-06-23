package com.disneystreaming.i21;

// I created this class to easily store the data types i wanted directly from the Conent.Java class.
// 
class Result implements java.lang.Comparable {
    private String title;
    private int finalScore;

    public String getTitle() {
        return this.title;
    }
    public void setTitle(String title)
    {
    	this.title = title;
    }
    public int getFinalScore() {
    	return this.finalScore;
    }
    public void setFinalScore(int finalScore){
    	this.finalScore = finalScore;
    }
	@Override
	public int compareTo(Object arg0) {
		// TODO Auto-generated method stub
		return 0;
	}
}
