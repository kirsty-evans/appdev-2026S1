namespace TermControl;

using System.Reflection;

public class TermControlDataLoader {

	
    private static string ConstructPath() {
        string basepath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        string[] splPath = basepath.Split("/");
        string newPath = "";

        for(int i = 0; i < splPath.Length; i++) {
            if(splPath[i] == "bin") {
                break;
            } else {
                newPath += "/" + splPath[i];
            }
        }

        
        return newPath;
    }

    public static string LoadContentsFromFile(string path) {

        string projectPath = ConstructPath();
        string data = "";
        using(StreamReader sr = File.OpenText(projectPath + "/" + path))
        {
            data = sr.ReadToEnd();
        }

        return data;
    }

    public static string TermControlDefaultRunner(string input, string programStr, string[] arguments) {
        
        TermController ctlr = new TermController()
            .ResetStdIn()
            .ResetStdOut()
            .RecordStdOut()
            .SetStringInput(input)
            .FindAndInvokeMain(programStr, arguments);

        ctlr.FlushStdOut();
        string output = ctlr.GetRawOutputString();
        ctlr.ResetAll();


        return output;
    }

	
    public static string TermControlDefaultRunnerWithSpeculation(string input, string[] spaces,
        string programStr, string[] arguments) {
        
        TermController ctlr = new TermController()
            .ResetStdIn()
            .ResetStdOut()
            .RecordStdOut()
            .SetStringInput(input)
            .FindAndInvokeMainWithSpeculation(programStr, arguments, spaces);

        ctlr.FlushStdOut();
        string output = ctlr.GetRawOutputString();
        
        ctlr.ResetAll();
        return output;
    }

}
