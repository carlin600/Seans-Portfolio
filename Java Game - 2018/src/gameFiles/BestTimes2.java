package gameFiles;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.FileOutputStream;
import java.io.IOException;
import javax.swing.JFrame;
import javax.swing.JOptionPane;

public class BestTimes2 extends JFrame implements ActionListener{

		//see notes @ start
		//couldnt get it to write out properly. 
		//sometimes it doesnt show it in the menu but it does in the actual notepad file
		
		public static void WriteOutBestTimes(String _val)
				  throws IOException {
				    FileOutputStream outputStream = new FileOutputStream("BestTimes.txt");
				    byte[] strToBytes = _val.getBytes();
				    outputStream.write(strToBytes);
				    JOptionPane.showMessageDialog(null, "Your High Score Is saved!");
				    outputStream.close();
				}
		
			
			
			@Override
			public void actionPerformed(ActionEvent e) {
				// TODO Auto-generated method stub
				
			}
			
			
}
