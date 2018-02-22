
Xamarin.Forms Todo Sample: .NET Standard &amp; EF Core Ed.
==========================================================
  
This is an adapted version of the [Xamarin.Forms Todo sample](https://developer.xamarin.com/samples/xamarin-forms/Todo/) ([repository](https://github.com/xamarin/xamarin-forms-samples/tree/master/Todo)), with the following key changes:

1. Instead of using the SQLite.Net PCL ORM for accessing SQLite, this version uses [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) ([repository](https://github.com/aspnet/EntityFramework)), since EF Core [started working on Xamarin.iOS](https://github.com/aspnet/EntityFramework/issues/7158). Jon Douglas' post and sample [Building Android Apps with Entity Framework](https://blog.xamarin.com/building-android-apps-with-entity-framework/) informed on this. At the moment, the sample is using EF Core v1.1.5, the latest v1.x at time of writing. While EF Core v2.x is now available, getting this sample working 100% with EF Core v2.x remains a challenge.

2. Instead of a Portable Class Library (PCL), app shared code is contained in a .NET Standard 2.0 library project, which is now a supported project template in Visual Studio 2017 as of v15.5.

3. For iOS and now also for Android, the project is configured for "Link Framework SDKs Only", as opposed to not linking. Notice the LinkDescription.xml includes some reflected types referenced by EF Core at runtime. Intersoft's post [Configure Linker in Production-Ready Application Release Build](http://developer.intersoftsolutions.com/display/crosslight/Configure+Linker+in+Production-Ready+Application+Release+Build) informed on this.

The sample app projects compile for and run successfully on each of Android, iOS, and UWP physical devices. 

You can use Visual Studio 2017 (PC) v15.5.6+ or Visual Studio 2017 for Mac v7.3.3+ to open the solution and compile the apps; of course, the UWP project only compiles in the PC edition.

I posted about this [at the Xamarin *Cross Platform with Xamarin* forum](https://forums.xamarin.com/discussion/95916/works-xamarin-forms-net-standard-entity-framework-core-for-sqlite-on-ios-android-uwp) and welcome comments there.

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
