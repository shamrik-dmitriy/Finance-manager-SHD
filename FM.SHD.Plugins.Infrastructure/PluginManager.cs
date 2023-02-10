using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace FM.SHD.Plugins.Infrastructure
{
    public class PluginManager
    {
        private readonly string _path;
        private readonly IServiceCollection _services;
        public ICollection<Assembly> Plugins { get; private set; } = new List<Assembly>();

        private IList<Type> _types;

        public IList<Type> Types
        {
            get
            {
                if (_types == null)
                {
                    LoadPlugins();
                }

                return _types.ToList();
            }
        }

        public PluginManager(IServiceCollection services, string path)
        {
            _path = path;
            _services = services;
        }

        public void LoadPlugins()
        {
            var dlls = Directory.GetFiles(Path.Combine(_path,"Modules"), "FM.SHD.Plugin.*.dll", SearchOption.TopDirectoryOnly);

            foreach (var dll in dlls)
            {
                var plugin = Assembly.LoadFrom(dll);
                Plugins.Add(plugin);
            }
        }

        public IServiceCollection UpdateServices()
        {
            var pluginClass = Plugins.First().GetTypes()
                .SingleOrDefault(type => typeof(IPlugin).IsAssignableFrom(type));
            //if (pluginClass == null) continue;

            var pluginInstance = Activator.CreateInstance(pluginClass, _services);
                
            var loadMethod = pluginClass.GetMethod("Add");
            var t = loadMethod.Invoke(pluginInstance, null);
            return (IServiceCollection)t;
            //loadMethod.Invoke(pluginInstance, null);
            
            foreach (var type in Types)
            {
                _services.AddTransient(type);
            }
        }


        /*   var moduleAssembly = System.Reflection.Assembly.LoadFrom(@"A:\Repositories\Finance-manager-SHD\FM.SHD.Plugin.Transaction\bin\Debug\net5.0-windows\FM.SHD.Plugin.Transaction.dll");
           var moduleTypes = moduleAssembly.GetTypes().Where(t => 
               t.GetInterfaces().Contains(typeof(IPlugin)));
       
     
     
       /*
       private static IEnumerable<Assembly> _plugins;
       
       public static IEnumerable<Assembly> Plugins => _plugins;

       public static void SetAssemblies(IEnumerable<Assembly> plugins)
       {
           _plugins = plugins;
       }

       /// <summary>
       /// Gets the first implementation of the type specified by the type parameter or null if no implementations found.
       /// </summary>
       /// <typeparam name="T">The type parameter to find implementation of.</typeparam>
       /// <returns></returns>
       public static Type GetImplementation<T>()
       {
           return GetImplementation<T>(null);
       }

       /// <summary>
       /// Gets the first implementation of the type specified by the type parameter and located in the plugins
       /// filtered by the predicate or null if no implementations found.
       /// </summary>
       /// <typeparam name="T">The type parameter to find implementation of.</typeparam>
       /// <param name="predicate">The predicate to filter the plugins.</param>
       /// <returns></returns>
       public static Type GetImplementation<T>(Func<Assembly, bool> predicate)
       {
           return GetImplementations<T>(predicate).FirstOrDefault();
       }

       /// <summary>
       /// Gets the implementations of the type specified by the type parameter.
       /// </summary>
       /// <typeparam name="T">The type parameter to find implementations of.</typeparam>
       /// <returns></returns>
       public static IEnumerable<Type> GetImplementations<T>()
       {
           return GetImplementations<T>(null);
       }

       /// <summary>
       /// Gets the implementations of the type specified by the type parameter and located in the plugins
       /// filtered by the predicate.
       /// </summary>
       /// <typeparam name="T">The type parameter to find implementations of.</typeparam>
       /// <param name="predicate">The predicate to filter the plugins.</param>
       /// <returns></returns>
       public static IEnumerable<Type> GetImplementations<T>(Func<Assembly, bool> predicate)
       {
           List<Type> implementations = new List<Type>();

           foreach (Assembly assembly in GetAssemblies(predicate))
               foreach (Type type in assembly.GetTypes())
                   if (typeof(T).GetTypeInfo().IsAssignableFrom(type) && type.GetTypeInfo().IsClass)
                       implementations.Add(type);

           return implementations;
       }

       /// <summary>
       /// Gets the new instance of the first implementation of the type specified by the type parameter
       /// or null if no implementations found.
       /// </summary>
       /// <typeparam name="T">The type parameter to find implementation of.</typeparam>
       /// <returns></returns>
       public static T GetInstance<T>()
       {
           return GetInstance<T>(null, new object[] { });
       }

       /// <summary>
       /// Gets the new instance (using constructor that matches the arguments) of the first implementation
       /// of the type specified by the type parameter or null if no implementations found.
       /// </summary>
       /// <typeparam name="T">The type parameter to find implementation of.</typeparam>
       /// <param name="args">The arguments to be passed to the constructor.</param>
       /// <returns></returns>
       public static T GetInstance<T>(params object[] args)
       {
           return GetInstance<T>(null, args);
       }

       /// <summary>
       /// Gets the new instance of the first implementation of the type specified by the type parameter
       /// and located in the plugins filtered by the predicate or null if no implementations found.
       /// </summary>
       /// <typeparam name="T">The type parameter to find implementation of.</typeparam>
       /// <param name="predicate">The predicate to filter the plugins.</param>
       /// <returns></returns>
       public static T GetInstance<T>(Func<Assembly, bool> predicate)
       {
           return GetInstances<T>(predicate).FirstOrDefault();
       }

       /// <summary>
       /// Gets the new instance (using constructor that matches the arguments) of the first implementation
       /// of the type specified by the type parameter and located in the plugins filtered by the predicate
       /// or null if no implementations found.
       /// </summary>
       /// <typeparam name="T">The type parameter to find implementation of.</typeparam>
       /// <param name="predicate">The predicate to filter the plugins.</param>
       /// <param name="args">The arguments to be passed to the constructor.</param>
       /// <returns></returns>
       public static T GetInstance<T>(Func<Assembly, bool> predicate, params object[] args)
       {
           return GetInstances<T>(predicate, args).FirstOrDefault();
       }

       /// <summary>
       /// Gets the new instances of the implementations of the type specified by the type parameter
       /// or empty enumeration if no implementations found.
       /// </summary>
       /// <typeparam name="T">The type parameter to find implementations of.</typeparam>
       /// <returns></returns>
       public static IEnumerable<T> GetInstances<T>()
       {
           return GetInstances<T>(null, new object[] { });
       }

       /// <summary>
       /// Gets the new instances (using constructor that matches the arguments) of the implementations
       /// of the type specified by the type parameter or empty enumeration if no implementations found.
       /// </summary>
       /// <typeparam name="T">The type parameter to find implementations of.</typeparam>
       /// <param name="args">The arguments to be passed to the constructors.</param>
       /// <returns></returns>
       public static IEnumerable<T> GetInstances<T>(params object[] args)
       {
           return GetInstances<T>(null, args);
       }

       /// <summary>
       /// Gets the new instances of the implementations of the type specified by the type parameter
       /// and located in the plugins filtered by the predicate or empty enumeration
       /// if no implementations found.
       /// </summary>
       /// <typeparam name="T">The type parameter to find implementations of.</typeparam>
       /// <param name="predicate">The predicate to filter the plugins.</param>
       /// <returns></returns>
       public static IEnumerable<T> GetInstances<T>(Func<Assembly, bool> predicate)
       {
           return GetInstances<T>(predicate, new object[] { });
       }

       /// <summary>
       /// Gets the new instances (using constructor that matches the arguments) of the implementations
       /// of the type specified by the type parameter and located in the plugins filtered by the predicate
       /// or empty enumeration if no implementations found.
       /// </summary>
       /// <typeparam name="T">The type parameter to find implementations of.</typeparam>
       /// <param name="predicate">The predicate to filter the plugins.</param>
       /// <param name="args">The arguments to be passed to the constructors.</param>
       /// <returns></returns>
       public static IEnumerable<T> GetInstances<T>(Func<Assembly, bool> predicate, params object[] args)
       {
           List<T> instances = new List<T>();

           foreach (Type implementation in GetImplementations<T>())
           {
               if (!implementation.GetTypeInfo().IsAbstract)
               {
                   T instance = (T)Activator.CreateInstance(implementation, args);

                   instances.Add(instance);
               }
           }

           return instances;
       }

       private static IEnumerable<Assembly> GetAssemblies(Func<Assembly, bool> predicate)
       {
           if (predicate == null)
               return Plugins;

           return Plugins.Where(predicate);
       }
    */
    }
}