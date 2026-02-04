namespace Timestable.Test;

using TermCtrl;


public class TimestableTest
{
    [Fact]
    public void TimestableTest_5()
    {
         TermController ctlr = new TermController()
            .RecordStdOut()
            .SetStringInput("5\n")
            .FindAndInvokeMain("Program, Timestable", new string[] {});

        ctlr.FlushStdOut();

        string output = ctlr.GetOutputString();
        string[] nlineOutput = output.Split("\n");

        Assert.Equal("Enter Number: ", nlineOutput[0]);
        Assert.Equal("5", nlineOutput[1]);
        Assert.Equal("10", nlineOutput[2]);
        Assert.Equal("15", nlineOutput[3]);
        Assert.Equal("20", nlineOutput[4]);
        Assert.Equal("25", nlineOutput[5]);
        Assert.Equal("30", nlineOutput[6]);
        Assert.Equal("35", nlineOutput[7]);
        Assert.Equal("40", nlineOutput[8]);
        Assert.Equal("45", nlineOutput[9]);
        Assert.Equal("50", nlineOutput[10]);
        Assert.Equal("55", nlineOutput[11]);
        Assert.Equal("60", nlineOutput[12]);

        ctlr.ResetAll();
    }
    
    [Fact]
    public void TimestableTest_2()
    {
         TermController ctlr = new TermController()
            .RecordStdOut()
            .SetStringInput("2\n")
            .FindAndInvokeMain("Program, Timestable", new string[] {});

        ctlr.FlushStdOut();

        string output = ctlr.GetOutputString();
        string[] nlineOutput = output.Split("\n");

        Assert.Equal("Enter Number: ", nlineOutput[0]);
        Assert.Equal("2", nlineOutput[1]);
        Assert.Equal("4", nlineOutput[2]);
        Assert.Equal("6", nlineOutput[3]);
        Assert.Equal("8", nlineOutput[4]);
        Assert.Equal("10", nlineOutput[5]);
        Assert.Equal("12", nlineOutput[6]);
        Assert.Equal("14", nlineOutput[7]);
        Assert.Equal("16", nlineOutput[8]);
        Assert.Equal("18", nlineOutput[9]);
        Assert.Equal("20", nlineOutput[10]);
        Assert.Equal("22", nlineOutput[11]);
        Assert.Equal("24", nlineOutput[12]);

        ctlr.ResetAll();
    }
    
    [Fact]
    public void TimestableTest_10()
    {
         TermController ctlr = new TermController()
            .RecordStdOut()
            .SetStringInput("10\n")
            .FindAndInvokeMain("Program, Timestable", new string[] {});

        ctlr.FlushStdOut();

        string output = ctlr.GetOutputString();
        string[] nlineOutput = output.Split("\n");

        Assert.Equal("Enter Number: ", nlineOutput[0]);
        Assert.Equal("10", nlineOutput[1]);
        Assert.Equal("20", nlineOutput[2]);
        Assert.Equal("30", nlineOutput[3]);
        Assert.Equal("40", nlineOutput[4]);
        Assert.Equal("50", nlineOutput[5]);
        Assert.Equal("60", nlineOutput[6]);
        Assert.Equal("70", nlineOutput[7]);
        Assert.Equal("80", nlineOutput[8]);
        Assert.Equal("90", nlineOutput[9]);
        Assert.Equal("100", nlineOutput[10]);
        Assert.Equal("110", nlineOutput[11]);
        Assert.Equal("120", nlineOutput[12]);

        ctlr.ResetAll();
    }
}
