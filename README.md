# UWP app with Autofac and multi-instance enabled

In my journey building [Nightingale REST client](https://github.com/jenius-apps/nightingale-rest-api-client), I had to change its architecture a couple times. The first time was for enabling dependency injection. I know there are many MVVM toolkits out there which provided dependency injection services, but my experience with ASP.NET Core and [Autofac](https://autofac.org/) led me to reuse Autofac for this side project. The second time I changed Nightingale's architecture was for enabling [multi-instance mode for UWP apps](https://docs.microsoft.com/en-us/windows/uwp/launch-resume/multi-instance-uwp). 

Today, multi-instance and Autofac are essential pieces of Nightingale. This repository serves as my way of recording the basic steps I went through in adding these two features in case I need to use them again in the future. Feel free to peruse the repository and try it out yourself for your UWP apps.

# Sample usage

1. Clone repo
1. Open `.sln` file
1. Press F5 to launch app in debug mode
1. Once the app is open, you can open a new instance by holding `Shift` then clicking the taskbar icon.

# How to understand this sample

- Clone and review the code to see where things are.
- Review the diffs of the commits. I purposefully set up the code-related commits to incrementally add pieces one by one. For example, one commit adds dependency injection without Autofac. The next commit adds Autofac. I did this to help folks understand each intermediate step from start to finish.
