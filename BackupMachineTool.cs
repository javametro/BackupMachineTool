using System;
using System.IO;

public class BackupMachineTool{
	
	public static void Main(string[] args){
		
		for(int i=0; i<args.length;i++){
			
			Console.WriteLine("Arg:{0}", args[i]);
		}
		// string usbDrive = args[0];
		// Console.WriteLine(usbDrive);
		
		// BackupMachineTool bmt = new BackupMachineTool();
		// Console.WriteLine("The directory you want to save is :");
		// bmt.ListDirectory();
	}
	
	public void CopyFile(){
		string sourceFile = @"C:\for.txt";
		string destinationFile = @"C:\test.txt";
		bool isrewrite = true;
		System.IO.File.Copy(sourceFile, destinationFile, isrewrite);
		
	}
	
	public void CopyFolder(){
		
		
	}
	
	public void FindUSBDrive(){
		
		
	}
	
	public void MakeDirectory(){
		
		Directory.CreateDirectory(@"C:\testDirectory");
	}
	
	public void ListDirectory(){
		
		string[] dirs;
	
		dirs = Directory.GetDirectories(@"C:\");
		
		foreach (string dir in dirs){
			Console.WriteLine(dir);
		}
	}
}