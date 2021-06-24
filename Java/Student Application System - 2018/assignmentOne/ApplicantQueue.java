package assignmentOne;


public class ApplicantQueue {
	
	private ListNode front;
	private ListNode rear;
	
	public ApplicantQueue(ListNode front, ListNode rear) {
		super();
		this.front = front;
		this.rear = rear;
	}

	public ListNode getFront() {
		return front;
	}

	public void setFront(ListNode front) {
		this.front = front;
	}

	public ListNode getRear() {
		return rear;
	}

	public void setRear(ListNode rear) {
		this.rear = rear;
	}
	
	//constructor creates to list nodes setting them to null
	
	
	
	
	
	ApplicantQueue()
		{
			front = null;
			rear = null;
		}
		
		public void add (DegreeApp newApp)
		{
			//create a new listnode and pass in the data you want it to store 
			ListNode next = new ListNode(newApp);
			
			
			//if there is nothing in it, make the new node the start and end 
			if(empty () == true) // or start == null
			{
				front = next;
				rear = next;
				
			}
			else
			{
				//if the new number is smaller than the start put it first and link it to the one that used to be first.
				if(next.getAppDetails().getPriority() < front.getAppDetails().getPriority())//in my book
				{
					next.setLink(front); // puts it first
					front = next; 		//start pointer now goes to new item
				}
				
				else
				{
					// if the new number is bigger than the end put it last, link it to the one that used to be first
					if(next.getAppDetails().getPriority() >= rear.getAppDetails().getPriority())
					{
						rear.setLink(next); // link the last one to the new one
						rear = next;		  // make the new one the last
					}
					else
					{
						//create a pair of list nodes to remember the position as we loop through the list
						ListNode prev;
						ListNode curr;
						prev = front; //prev refers to the first item
						curr = front.getLink(); //curr refers to the second
						
						//while new num is bigger than the current keep going 
						while(curr.getAppDetails().getPriority() < next.getAppDetails().getPriority());
						{
							prev = curr;
							curr = curr.getLink();
						}
						
						//puts the new num in between prev and curr
						prev.setLink(next);
						next.setLink(curr);
					}
						
				}
			
			}
		
		}
		
		public void removeApplicant (String email)
		{
			ListNode curr;
			ListNode prev;
			
			//checks if the specific email we want to remove is the first one
			if(front.getAppDetails().getEmail().equals(email) == true)
			{
				//sets the front to be the item the front item pointed to
				curr = front;
				front = front.getLink();
				curr = null; //remove the first item
			}
			else //goes to the middle
			{
				prev = front; //prev refers to the first item
				curr = front.getLink(); //curr refers to the second
				
				
				//keeps moving through the list until it finds the one its looking for
				while(curr.getAppDetails().getEmail().equals(email) != true && curr != null)
				{
					prev = curr;
					curr = curr.getLink();				
				}
			
				
				//if one still isnt found, the one we are currently is set to previous and then it moves on to the next
				if(curr != null)
					prev.setLink(curr.getLink());
				
				
			}
			
		}
		
		//gets the very top applicant by priority
		public int peek()
		{
			return front.getAppDetails().getPriority();
		}
		
		//displays all applicants, showing all their details entered.
		public String display ()
		{
			String s = "";
			
			ListNode current = front;
			
			
			//loops throught the ordered list until there is none left to go through(hence the != null)
			while(current != null)
			{
				
				s += ("\n" +  current.getAppDetails()); 
				current = current.getLink();
			}
			

			return s;
		}
		
		//this is mainly for allocation, it displays all the applicants by priority whilst also setting their place confirmed.
		public String disPriority (int priority)
		{
			String s = "";
			
			ListNode current = front;
			
			for(int i = 0; i < priority; i++)
			{
				int option = current.getAppDetails().getPriority();
				
				switch(option)
				{
				case 1:
					current.getAppDetails().setPlaceConfirmed(true);
					break;
				case 2:
					current.getAppDetails().setPlaceConfirmed(true);
					break;
				case 3:
					current.getAppDetails().setPlaceConfirmed(true);
					break;
				case 4:
					current.getAppDetails().setPlaceConfirmed(false);
					break;
				}
			
			
				//displays all their details in a separate display in the allocate section
				s += ("\n" +  
						 current.getAppDetails().getName() + "\n" + 
						 current.getAppDetails().getEmail() + "\n" +
						 current.getAppDetails().getTelNo() + "\n" +
						 current.getAppDetails().getDateOfApplication() + "\n" +
						 current.getAppDetails().getUcasPoints() + "\n" +
						 current.getAppDetails().getPriority() + "\n" +
						 current.getAppDetails().isPlaceConfirmed()); 
				current = current.getLink();
			}
				
				
			

			return s;
		}
		
		public boolean empty()
		{
			if(front == null)
				return true;
			else
				return false;
		}
		
		//search method for when you want to find an applicant by their email for either edit or delete.
		public DegreeApp search(String email)
		{

			ListNode current = front;
			while(current != null && current.getAppDetails().getEmail().equals(email) != true)
			{
				current = current.getLink();
			}
			if(current != null)
				return current.getAppDetails();
			else
				return null;// dunno about this part so put it to null
		}
		
		
		//converts anything called with this method to a string, e.g 'txtUCAS.setText(Integer.toString(edit.getUcasPoints()));' (from my GUI ~Sc)
		public String toString()
		{
			String s = "";
			
			ListNode current = front;
			
			
			
			while(current != null)
			{
				
				s += ("\n" +  current.getAppDetails()); 
				current = current.getLink();
			}
			

			return s;

		}
		
		
		
	
		
	}

	
	
	
	


