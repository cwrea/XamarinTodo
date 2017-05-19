
Xamarin.Forms Todo Sample: .NET Standard &amp; EF Core Ed.
==========================================================
  
This is an adapted version of the [Xamarin.Forms Todo sample](https://developer.xamarin.com/samples/xamarin-forms/Todo/) ([repository](https://github.com/xamarin/xamarin-forms-samples/tree/master/Todo)), with the following key changes:

1. Instead of using the SQLite.Net PCL ORM for accessing SQLite, this version uses [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) ([repository](https://github.com/aspnet/EntityFramework)), since EF Core [recently started working on Xamarin.iOS](https://github.com/aspnet/EntityFramework/issues/7158). Jon Douglas' post and sample [Building Android Apps with Entity Framework](https://blog.xamarin.com/building-android-apps-with-entity-framework/) informed on this.

2. Instead of a Portable Class Library (PCL), app shared code is contained in a .NET Standard 1.4 library project. Oren Novotny's post on [Using Xamarin Forms with .NET Standard &mdash; VS 2017 Edition](https://oren.codes/2017/04/23/using-xamarin-forms-with-net-standard-vs-2017-edition/) informed on this.

3. For iOS in particular, the project is configured for "Link Framework SDKs Only", as opposed to not linking. Notice the LinkDescription.xml includes some reflected types referenced by EF Core at runtime. Intersoft's post [Configure Linker in Production-Ready Application Release Build](http://developer.intersoftsolutions.com/display/crosslight/Configure+Linker+in+Production-Ready+Application+Release+Build) informed on this.

The sample app projects compile for and run successfully on each of Android, iOS, and UWP physical devices. 

You can use either Visual Studio 2017 (PC) v15.2+ or Visual Studio 2017 for Mac v7.0+ to open the solution and compile the apps; of course, the UWP project only compiles in the PC edition.

Regards,

Chris W. Rea  
@cwrea

---

License
-------

This adapted sample inherits the Apache License 2.0 from the original sample:

   Copyright 2011 Xamarin Inc

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.

---

*Original README.md follows:*

Todo
====

This sample demonstrates a Todo list application where the data is stored and accessed in a local SQLite database.

The app functionality is:

- View a list of tasks.
- Add a new item to the list of tasks.
- Set a task's status to 'completed'.

In all cases the tasks are stored in a local SQLite database.

For more information about the sample see [Working with a Local Database](https://developer.xamarin.com/guides/xamarin-forms/working-with/databases/).

Authors
-------

Craig Dunn, Bryan Costanich
