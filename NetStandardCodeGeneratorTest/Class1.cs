using System;

namespace NetStandardCodeGeneratorTest
{
    public class Class1
    {
		public string GetTestValue()
		{
			// Note there's no source file in this project (if freshly pulled) that contains a "GeneratedClass" class with a "TestValue" member.
			// On compilation, a Target in the .csproj will be run that generates a source file needed for this.
			// Afterwards, the source file will persist.
			return GeneratedClass.TestValue;
		}
    }
}
