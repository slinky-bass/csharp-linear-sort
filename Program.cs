/*
 * Created by SharpDevelop.
 * User: Slinky_Bass
 * Date: 2016/04/04
 * Time: 09:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace linear_sort
{
	
	class Program
	{	
	
		public static void Main()
		{	
			string line;
			StreamReader OriginalCatalogue = new StreamReader(@"c:\Sites\Mus777.cat");
			StreamWriter ReorderedCatalogue = new StreamWriter(@"c:\Sites\reorder.cat");
			List<KeyValuePair<string, string>> BarcodeList = new List<KeyValuePair<string, string>>();
			SortIt BarcodeSort = new SortIt(); //<--- mah very own class, instantiated!!!111!
		
			while((line = OriginalCatalogue.ReadLine()) != null)
			{		
				if (line != "") 
				{	
					string Barcode = line.Substring(15, 13);	
					BarcodeList.Add(new KeyValuePair<string, string>(Barcode, line));
				}
			}
			
			BarcodeSort.InsertionSort(BarcodeList);
			
			//Console.WriteLine("test");
			//Console.WriteLine("Barcode: {0} Line: {1}", Barcode, line);
			
			foreach (KeyValuePair<string, string> kvp in BarcodeSort.SortedResult) 
			{
				ReorderedCatalogue.WriteLine(kvp.Value);
			}
			
			OriginalCatalogue.Close();
			ReorderedCatalogue.Close();
		}	
	}		
}