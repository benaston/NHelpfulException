NHelpfulException
====

A simple wrapper for System.Exception to help make exceptions more meaningful.

Usage:
--------
**1. Create your HelpfulException**

```C#


    public class MyHelpfulException : HelpfulException
    {
        public MyHelpfulException(string problemDescription, 
								  string[] resolutionSuggestions = default(string[]),
                                  Exception innerException = default(Exception))
            : base(problemDescription, resolutionSuggestions, innerException) {}
    }

```

**2. Instantiate and throw the exception**
	
```C#


	throw new MyHelpfulException("Coffee supply too low.", 
								  new []{ "Buy some more coffee.", 
								          "Stop drinking so much coffee." });

```

**3. Bask in the glory of a meaningful exception message**

```
	
	Coffee supply too low.
    Suggestions:
     - Buy some more coffee.
	 - Stop drinking so much coffee.
	 
```


License & Copyright
--------

This software is released under the GNU Lesser GPL. It is Copright 2011, Ben Aston. I may be contacted at ben@bj.ma.