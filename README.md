[![Build status](https://ci.appveyor.com/api/projects/status/wdjh1h1ooa9temu9?svg=true)](https://ci.appveyor.com/project/jaredhwilliams/fizzbuzz)

# FizzBuzz
This is a FizzBuzz style programming exercise in C#. It has the following requirements:
1. The client application should be able to provide their own list of divisor to word pairs.
2. The client application should be able to provide as many pairs as they want.
3. The client application should be able to provide an upper bound up to int.MaxValue.
4. The FizzBuzz library should be callable from .NET client applications of any type (e.g. web apps, mobile apps, console apps, etc.).
5. The FizzBuzz library should have relevant unit tests using the NUnit framework.
6. The source should be stored in a Git repository and be hosted on Github. 
7. The repository should contain an automated build script that builds the solution and runs the unit tests. 
8. The repository should be integrated with a CI server to kick off automated builds/tests, send notifications, allow viewing of build status/history, etc. 

# Built With
* [NUnit](http://nunit.org/) (requirement #5 above)
* [Git](https://git-scm.com/) and [GitHub](https://github.com/) (requirement #6 above)
* [Cake](https://cakebuild.net/) (requirement #7 above)
* [AppVeyor](https://www.appveyor.com/) (requirement #8 above). Note: The AppVeyor FizzBuzz project page is [here](https://ci.appveyor.com/project/jaredhwilliams/fizzbuzz).
* [Moq](https://github.com/moq/moq)
* [Shouldly](https://github.com/shouldly/shouldly)
* [GitHub Visual Studio Extension](https://visualstudio.github.com/)
* [AxoCover Visual Studio Extension](https://marketplace.visualstudio.com/items?itemName=axodox1.AxoCover)