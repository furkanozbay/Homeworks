
import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.Iterator;
import java.util.Locale;
import java.util.StringTokenizer;
import java.util.TreeMap;
import java.util.TreeSet;
/**
 * 
 * @author furkanozbay
 */
public class InvertedIndex {

	public static void main(String[] args) {
		if (args[0] == null) {
			System.out.println("Please give arguman");
			System.exit(0);
		}
		new InvertedIndex().grep(args[0]);
	}

	public void grep(String path) {
		Locale.setDefault(new Locale("US"));
		TreeMap<String, TreeSet<String>> wordsAndDocs = new TreeMap<String, TreeSet<String>>();
		TreeSet<String> fileNames = new TreeSet<String>();
		BufferedReader reader = null;
		File[] file = new File(path).listFiles();
		for (File f : file) {
			fileNames.add(f.getName().replaceFirst("[.][^.]+$", ""));
			// System.out.println(f.getName().replaceFirst("[.][^.]+$", ""));

			try {
				reader = new BufferedReader(new FileReader(f));
			} catch (Exception e) {
				System.out
						.println("File couldn't be founded " + e.getMessage());
			}

			String satir = null;
			try {
				satir = reader.readLine();
			} catch (IOException e1) {
			}
			while (satir != null) {
				StringTokenizer tk = new StringTokenizer(satir,
						"?:;'!>.)<,(/}-0123456789”“’\"… ");
				while (tk.hasMoreTokens()) {
					String s = tk.nextToken().toLowerCase();
					if (s.length() == 0 || s.length() == 1 || s.length() == 2)
						continue;
					TreeSet<String> temp = wordsAndDocs.get(s);
					if (temp == null)
						temp = new TreeSet<String>();
					temp.add(f.getName().replaceFirst("[.][^.]+$", ""));
					wordsAndDocs.put(s, temp);
				}
				try {
					satir = reader.readLine();
				} catch (IOException e) {
					System.out.println("Error!");
				}

			}
		}
		try {
			reader.close();
		} catch (IOException e) {
		}
		PrintWriter pw = null;
		try {
			pw = new PrintWriter(new FileWriter("Output File Path"));
			// pw.println("There is " + wordsAndDocs.keySet().size()
			// + " rows and " + fileNames.size() + " columns");

		} catch (IOException e) {
		}

		// System.out.println("");

		for (String s : wordsAndDocs.keySet()) {
			StringBuilder emptychar = new StringBuilder();
			for (int i = 0; i < 23 - s.length(); i++) {
				emptychar.append(" ");
			}
			// System.out.print(s + emptychar.toString());
			pw.print(s + " (" + wordsAndDocs.get(s).size() + ")"
					+ emptychar.toString());
			Iterator<String> it = wordsAndDocs.get(s).iterator();
			while (it.hasNext())
				pw.print("->" + it.next());
				pw.println();

		}
		pw.close();
	}
}
