
import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.util.HashSet;
import java.util.Iterator;
import java.util.Locale;
import java.util.Set;
import java.util.StringTokenizer;
import java.util.TreeMap;
/**
 * 
 * @author furkanozbay
 */
public class Isearcher {
	public static void main(String[] args) {
		if(args[0]==null){
			System.out.println("Please give arguman");
			System.exit(0);
		}
			new Isearcher().getData(args[0]);
	}

	public void getData(String word) {
		Locale.setDefault(new Locale("US")); 
		TreeMap<String, Set<String>> wordsAndDocs = new TreeMap<String, Set<String>>();
		BufferedReader reader = null;
		File file = new File("Output File");
		try {
			reader = new BufferedReader(new FileReader(file));
		} catch (Exception e) {
			System.out.println("File couldn't be founded " + e.getMessage());
		}

		String satir = null;
		try {
			satir = reader.readLine();
		} catch (IOException e1) {
		}
		int i = 0;
		while (satir != null) {
			String putted = "";
			i++;
			StringTokenizer tk = new StringTokenizer(satir, "->");
			while (tk.hasMoreTokens()) {
				String s = tk.nextToken().toLowerCase();
				if(i==1){
					putted = s.split(" ")[0];
					i = 0;
				}
				else{
					Set<String> temp = wordsAndDocs.get(putted);
					if (temp == null)
						temp = new HashSet<String>();
					temp.add(s);
					wordsAndDocs.put(putted, temp);
				
				}
			}
			try {
				satir = reader.readLine();
			} catch (IOException e) {
				System.out.println("Error!");
			}

		}
		Iterator<String> iter = wordsAndDocs.get(word).iterator();
		System.out.print("The word " + word +"'s posting list: ");
		while(iter.hasNext())
			System.out.print(iter.next()+"   ");
		
	}
}
