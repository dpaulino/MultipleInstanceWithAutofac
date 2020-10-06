# UWP app with Autofac and multi-instance enabled

In my journey building [Nightingale REST client](https://github.com/jenius-apps/nightingale-rest-api-client), I had to change its architecture a couple times. The first time was for enabling dependency injection. I know there are many MVVM toolkits out there which provided dependency injection services, but my experience with ASP.NET Core and [Autofac](https://autofac.org/) led me to reuse Autofac for this side project. The second time I changed Nightingale's architecture was for enabling [multi-instance mode for UWP apps](https://docs.microsoft.com/en-us/windows/uwp/launch-resume/multi-instance-uwp). 

Today, multi-instance and Autofac are essential pieces of Nightingale. This repository serves as my way of recording the basic steps I went through in adding these two features in case I need to use them again in the future. Feel free to peruse the repository and try it out yourself for your UWP apps.
