package plotDataForPairWiseRanking;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.io.PrintWriter;
import java.io.UnsupportedEncodingException;
import java.util.ArrayList;

public class mainComponent {

	public static void main(String[] args) throws FileNotFoundException, UnsupportedEncodingException {
		// TODO Auto-generated method stub
		if (args.length < 3) {
			System.out.println("Please provide the following in the quested order:");
			System.out.println("1) The path of the file Normalized_EDP_1.txt for the ARM processor.");
			System.out.println("2) The path of the file Normalized_EDP_1.txt for the Mobile processor.");
			System.out.println("3) The path of the file Normalized_EDP_1.txt for the Server processor.");
			System.out.println("4) The full path and file name to where to create the new data.");
			System.exit(1);
		}

		ArrayList<String> armProcessorEDP = new ArrayList<>();
		ArrayList<String> mobileProcessorEDP = new ArrayList<>();
		ArrayList<String> serverProcessorEDP = new ArrayList<>();
		ArrayList<String> tasksNames = new ArrayList<>();
		BufferedReader br = null;
		FileReader fr = null;
		for (int i = 0; i <= 2; ++i) {
			try {
				fr = new FileReader(args[i]);
				br = new BufferedReader(fr);
				String sCurrentLine;
				while ((sCurrentLine = br.readLine()) != null) {
					switch (i) {
					case 0:
						armProcessorEDP.add(sCurrentLine);
						break;
					case 1:
						mobileProcessorEDP.add(sCurrentLine);
						break;
					case 2:
						serverProcessorEDP.add(sCurrentLine);
						break;
					default:
						System.out.println("[Error] Please check again you command line arguments");
						System.exit(1);
					}
				}
			} catch (IOException e) {
				e.printStackTrace();
			} finally {
				try {
					if (br != null)
						br.close();
					if (fr != null)
						fr.close();
				} catch (IOException ex) {
					ex.printStackTrace();
				}
			}
		}
		
		//Get tasks names
		for (int i = 0; i < armProcessorEDP.size(); ++i) {
			String[] splinter = armProcessorEDP.get(i).split("\\s+");
			tasksNames.add(splinter[0]);
		}
		
		float[][] arrayForARM = new float[25][14];
		float[][] arrayForMobile = new float[25][14];
		float[][] arrayForServer = new float[25][14];
		
		for (int i = 0; i<armProcessorEDP.size(); ++i) {
			String[] splitARM = armProcessorEDP.get(i).split("\\s+");
			String[] splitMobile = mobileProcessorEDP.get(i).split("\\s+");
			String[] splitServer = serverProcessorEDP.get(i).split("\\s+");
			
			for (int j = 1; j <splitARM.length; ++j) {
				arrayForARM[i][j-1] = Float.parseFloat(splitARM[j]);
				arrayForMobile[i][j-1] = Float.parseFloat(splitMobile[j]);
				arrayForServer[i][j-1] = Float.parseFloat(splitServer[j]);
			}
		}
		
		// Write all in a single file
		PrintWriter writer = new PrintWriter(args[3], "UTF-8");
		for (int i = 1; i <=14; ++i) {
			for (int j = 0; j < 25; ++j) {
				writer.println(i+" " + arrayForARM[j][i-1] + " " + arrayForMobile[j][i-1] + " " + arrayForServer[j][i-1] );
			}
		}
		
		writer.close();
	}

}
