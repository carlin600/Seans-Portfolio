	package assignmentOne;

public class ListNode {

	private DegreeApp appDetails;
	private ListNode link;
	
	public ListNode(DegreeApp newApp) {
		this.appDetails = newApp;
		this.link = null;
	}
	
	
	
	public DegreeApp getAppDetails() {
		return appDetails;
	}
	public void setAppDetails(DegreeApp appDetails) {
		this.appDetails = appDetails;
	}
	public ListNode getLink() {
		return link;
	}
	public void setLink(ListNode link) {
		this.link = link;
	}
	
	
}
