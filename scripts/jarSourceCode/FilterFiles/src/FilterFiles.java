import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.io.PrintWriter;
import java.io.UnsupportedEncodingException;
import java.text.DecimalFormat;
import java.util.ArrayList;
import java.lang.Math;

public class FilterFiles {

	public static void main(String[] args) throws IOException {
		// TODO Auto-generated method stub
		BufferedReader br = null;
		FileReader fr = null;
		int numberOfTasks = Integer.parseInt(args[2]);
		int numberOfLanguages = Integer.parseInt(args[3]);
		ArrayList<String> arrayWithEnergyResults = new ArrayList<>();
		ArrayList<String> arrayWithPerformanceResults = new ArrayList<>();
		for (int i = 0; i < 2; ++i) {
			try {
				fr = new FileReader(args[i]);
				br = new BufferedReader(fr);
				String sCurrentLine;
				while ((sCurrentLine = br.readLine()) != null) {
					if (i == 0)
						arrayWithEnergyResults.add(sCurrentLine);
					else if (i == 1)
						arrayWithPerformanceResults.add(sCurrentLine);
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

		DecimalFormat df = new DecimalFormat();
		df.setMaximumFractionDigits(2);
		float lowestEDP = 0;
		float highestEDP = 0;
		float[] newLowestEDP = new float[numberOfLanguages * numberOfTasks];
		float[] newHighestEDP = new float[numberOfLanguages * numberOfTasks];
		int counter = 0;
		// Making use of EDP = Energy * (Delay)^w where w = 1,2, and 3
		for (int n = 1; n < 4; ++n) {
			PrintWriter writer = new PrintWriter("EnergyDelayProduct_Weight_" + n + ".txt", "UTF-8");
			for (int j = 0; j < arrayWithEnergyResults.size(); ++j) {
				String[] split_Energy = arrayWithEnergyResults.get(j).split("\\s+");
				String[] split_Performance = arrayWithPerformanceResults.get(j).split("\\s+");
				String line = split_Energy[0] + ": ";
				for (int i = 1; i < split_Energy.length; ++i) {
					double energyValue = Double.parseDouble(split_Energy[i]);
					double performanceValue = Double.parseDouble(split_Performance[i]);
					line += " " + df.format(energyValue * (Math.pow(performanceValue, (double) n)));
					String str = df.format(energyValue * (Math.pow(performanceValue, (double) n))).toString()
							.replaceAll(",", "");
					//Retrieve the Lowest EDP
					if (lowestEDP == 0 && Float.parseFloat(str) != 0 && Float.parseFloat(str) != -1 ) {
						lowestEDP = Float.parseFloat(str);
					} else if (lowestEDP > Float.parseFloat(str) && Float.parseFloat(str) != 0 && Float.parseFloat(str) != -1 ) {
						lowestEDP = Float.parseFloat(str);
					}
					
					//Retrieve the Highest EDP
					if (highestEDP < Float.parseFloat(str)) {
						highestEDP = Float.parseFloat(str);
					}
				}
				writer.println(line);
				newLowestEDP[counter] = lowestEDP;
				newHighestEDP[counter] = highestEDP;
				counter++;
				lowestEDP = 0;
				highestEDP = 0;
			}
			writer.close();
		}

		/*
		 * At this part we are going to divide all our results with the lowest
		 * EDP to normalize them. We normalize all our results based on the
		 * lowest EDP to have 1 as the lowest number
		 */
		int counter1=0;
		for (int n = 1; n < 4; ++n) {
			PrintWriter writer = new PrintWriter("Normalized_EDP_" + n + ".txt", "UTF-8");
			File file = new File("EnergyDelayProduct_Weight_" + n + ".txt");
			FileReader fileReader = new FileReader(file);
			BufferedReader bufferedReader = new BufferedReader(fileReader);
			String line;
			String writeBackLine = null;
			while ((line = bufferedReader.readLine()) != null) {
				String[] splitWhiteSpace = line.split("\\s+");
				writeBackLine = splitWhiteSpace[0];
				for (int i = 1; i < splitWhiteSpace.length; ++i) {
					float dividend = Float.parseFloat(splitWhiteSpace[i].replace(",", ""));
					if (dividend != -1 && dividend != 0) {
					writeBackLine += " " + df.format(Math.log((double) dividend / newLowestEDP[counter1]));
					} else {
						writeBackLine += " " + df.format(dividend);
					}
					//writeBackLine += " " + df.format((double) dividend / newLowestEDP[counter1]);
				}
				counter1++;
				writer.println(writeBackLine);
			}
			writer.close();
			fileReader.close();
		}
		
		
		//Create files with the lowest and the highest Energy Delay Products
		counter1=0;
		for (int n = 1; n < 4; ++n) {
			PrintWriter writer = new PrintWriter("Normalized_EDP_" + n + "_Lowest_and_Highest.txt", "UTF-8");
			File file = new File("EnergyDelayProduct_Weight_" + n + ".txt");
			FileReader fileReader = new FileReader(file);
			BufferedReader bufferedReader = new BufferedReader(fileReader);
			String line;
			String writeBackLine = null;
			while ((line = bufferedReader.readLine()) != null) {
				String[] splitWhiteSpace = line.split("\\s+");
				writeBackLine = splitWhiteSpace[0];
				//for (int i = 1; i < splitWhiteSpace.length; ++i) {
					//float dividend = Float.parseFloat(splitWhiteSpace[i].replace(",", ""));
					//if (dividend != -1 && dividend != 0) {
					writeBackLine += " Lowest -> " + df.format(newLowestEDP[counter1]) + " Highest -> " + df.format(newHighestEDP[counter1]) + " Difference -> " + df.format(newHighestEDP[counter1] / newLowestEDP[counter1]);
					//} else {
					//	writeBackLine += " " + df.format(dividend);
				//	}
					//writeBackLine += " " + df.format((double) dividend / newLowestEDP[counter1]);
				//}
				counter1++;
				writer.println(writeBackLine);
			}
			writer.close();
			fileReader.close();
		}
		

		System.out.println("Execution done, you can collect now your results");
	}

}
