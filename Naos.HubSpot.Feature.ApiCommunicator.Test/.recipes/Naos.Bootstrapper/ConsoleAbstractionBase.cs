﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConsoleAbstractionBase.cs" company="Naos Project">
//   Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
// <auto-generated>
//   Sourced from NuGet package. Will be overwritten with package update except in 'Naos.Bootstrapper.Recipes.Core.Console' source.
// </auto-generated>
// --------------------------------------------------------------------------------------------------------------------

namespace Naos.Bootstrapper
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
<<<<<<< HEAD
    using System.Globalization;
=======
>>>>>>> f299d8dbc5dc7e0abcb0c85480e26493b239856a
    using System.IO;
    using System.Linq;
    using System.Reflection;

    using CLAP;

    using Naos.Configuration.Domain;
    using Naos.Diagnostics.Domain;
    using Naos.Diagnostics.Recipes;
    using Naos.Logging.Domain;
    using Naos.Logging.Persistence;
    using Naos.Telemetry.Domain;

    using OBeautifulCode.Assertion.Recipes;
    using OBeautifulCode.Collection.Recipes;
    using OBeautifulCode.Representation.System;
<<<<<<< HEAD
    using OBeautifulCode.Serialization;
=======
>>>>>>> f299d8dbc5dc7e0abcb0c85480e26493b239856a
    using static System.FormattableString;

    /// <summary>
    /// Abstraction for use with <see cref="CLAP" /> to provide basic command line interaction.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1053:StaticHolderTypesShouldNotHaveConstructors", Justification = "Cannot be static for command line contract.")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [System.CodeDom.Compiler.GeneratedCode("Naos.Bootstrapper.Recipes.Console", "See package version number")]
    public abstract class ConsoleAbstractionBase
    {
        /// <summary>
<<<<<<< HEAD
        /// The default prefix used in <see cref="PrefixAnnounce"/>.
        /// </summary>
        public const string DefaultAnnouncementPrefix = "- ";

        /// <summary>
        /// The padding used by the <see cref="PrefixAnnounce"/>.
        /// </summary>
        public const string DefaultAnnouncementPadding = "    ";

        private static IReadOnlyCollection<TypeRepresentation> globalTypeRepresentationsOfExceptionsToOmitStackTraceFrom = new List<TypeRepresentation>();

        /// <summary>
        /// Updates the type representations of exceptions to omit stack trace from.
        /// </summary>
        /// <param name="typeRepresentationsOfExceptionsToOmitStackTraceFrom">The type representations of exceptions to omit stack trace from.</param>
        public static void UpdateTypeRepresentationsOfExceptionsToOmitStackTraceFrom(
            IReadOnlyCollection<TypeRepresentation> typeRepresentationsOfExceptionsToOmitStackTraceFrom)
        {
            globalTypeRepresentationsOfExceptionsToOmitStackTraceFrom = typeRepresentationsOfExceptionsToOmitStackTraceFrom;
        }
=======
        /// Gets the exception types that should fail but NOT print the stack trace as the message is sufficient to understand the issue (useful for input failures). 
        /// </summary>
        protected static IReadOnlyCollection<TypeRepresentation> ExceptionTypeRepresentationsToOnlyPrintMessage { get; set; } = new TypeRepresentation[0];
>>>>>>> f299d8dbc5dc7e0abcb0c85480e26493b239856a

        /// <summary>
        /// Performs the entry point pre-checks; custom as well as 'RequiresElevatedPrivileges'.
        /// </summary>
        public void PerformEntryPointPreChecks()
        {
            if (this.RequiresElevatedPrivileges)
            {
                if (!ProcessHelpers.IsCurrentlyRunningAsAdmin())
                {
                    throw new NotSupportedException("This application requires elevated privileges, please run as administrator.");
                }
            }

            this.CustomPerformEntryPointPreChecks();
        }

        /// <summary>
<<<<<<< HEAD
        /// Gets the exception types that should fail but NOT print the stack trace as the message is sufficient to understand the issue (useful for input failures). 
        /// </summary>
        public virtual IReadOnlyCollection<TypeRepresentation> ExceptionTypeRepresentationsToOnlyPrintMessage => new TypeRepresentation[0];

        /// <summary>
        /// Gets a value indicating whether or not the application requires elevated privileges (ADMIN).
        /// </summary>
        protected virtual bool RequiresElevatedPrivileges => false;

        /// <summary>
=======
>>>>>>> f299d8dbc5dc7e0abcb0c85480e26493b239856a
        /// Extensible item to add additional pre-checks to be evaluated before the CLAP interface launches.
        /// </summary>
        protected virtual void CustomPerformEntryPointPreChecks()
        {
            /* no-op but can be overridden in order to perform checks before activating the CLAP interface and throw an exception. */
        }

        /// <summary>
<<<<<<< HEAD
=======
        /// Gets a value indicating whether or not the application requires elevated privileges (ADMIN).
        /// </summary>
        protected virtual bool RequiresElevatedPrivileges => false;

        /// <summary>
>>>>>>> f299d8dbc5dc7e0abcb0c85480e26493b239856a
        /// Entry point to simulate a failure.
        /// </summary>
        /// <param name="debug">Optional indication to launch the debugger from inside the application (default is false).</param>
        /// <param name="message">Message to use when creating a SimulatedFailureException.</param>
        /// <param name="environment">Optional value to use when setting the Naos.Configuration precedence to use specific settings.</param>
        [Verb(Aliases = nameof(WellKnownConsoleVerb.Fail), IsDefault = false, Description = "Throws an exception with provided message to simulate an error and confirm correct setup;\r\n            example usage: [Harness].exe fail /message='My Message.'\r\n                           [Harness].exe fail /message='My Message.' /debug=true\r\n                           [Harness].exe fail /message='My Message.' /environment=ExampleDevelopment\r\n                           [Harness].exe fail /message='My Message.' /environment=ExampleDevelopment /debug=true\r\n")]
        public static void ThrowSimulatedFailureException(
            [Aliases("")] [Description("Launches the debugger.")] [DefaultValue(false)] bool debug,
            [Aliases("")] [Required] [Description("Message to use when creating a SimulatedFailureException.")] string message,
            [Aliases("")] [Description("Sets the Naos.Configuration precedence to use specific settings.")] [DefaultValue(null)] string environment)
        {
            /*---------------------------------------------------------------------------*
             * Any method should run this logic to debug, setup config & logging, etc.   *
             *---------------------------------------------------------------------------*/
            CommonSetup(debug, environment);

            /*---------------------------------------------------------------------------*
             * This is not necessary but often very useful to print out the arguments.   *
             *---------------------------------------------------------------------------*/
            PrintArguments(new { message, environment });

            /*---------------------------------------------------------------------------*
             * Throw an exception after all logging is setup which will excercise the    *
             * top level error handling and can ensure correct setup.  Uses the type     *
             * SimulatedFailureException from Naos.Diagnostics.Domain so they can easily *
             * be filtered out if needed to avoid panic or triggering alarms.            *
             *---------------------------------------------------------------------------*/
            throw new SimulatedFailureException(message);
        }

        /// <summary>
        /// Entry point to log a message and exit gracefully.
        /// </summary>
        /// <param name="debug">Optional indication to launch the debugger from inside the application (default is false).</param>
        /// <param name="message">Message to log.</param>
        /// <param name="environment">Optional value to use when setting the Naos.Configuration precedence to use specific settings.</param>
        [Verb(Aliases = nameof(WellKnownConsoleVerb.Pass), IsDefault = false, Description = "Logs the provided message to confirm correct setup;\r\n            example usage: [Harness].exe pass /message='My Message.'\r\n                           [Harness].exe pass /message='My Message.' /debug=true\r\n                           [Harness].exe pass /message='My Message.' /environment=ExampleDevelopment\r\n                           [Harness].exe pass /message='My Message.' /environment=ExampleDevelopment /debug=true\r\n")]
        public static void LogAndExitGracefully(
            [Aliases("")] [Description("Launches the debugger.")] [DefaultValue(false)] bool debug,
            [Aliases("")] [Required] [Description("Message to log.")] string message,
            [Aliases("")] [Description("Sets the Naos.Configuration precedence to use specific settings.")] [DefaultValue(null)] string environment)
        {
            /*---------------------------------------------------------------------------*
             * Any method should run this logic to debug, setup config & logging, etc.   *
             *---------------------------------------------------------------------------*/
            CommonSetup(debug, environment);

            /*---------------------------------------------------------------------------*
             * This is not necessary but often very useful to print out the arguments.   *
             *---------------------------------------------------------------------------*/
            PrintArguments(new { message, environment });

            /*---------------------------------------------------------------------------*
             * Write message after all logging is setup which will confirm setup.        *
             *---------------------------------------------------------------------------*/
            Its.Log.Instrumentation.Log.Write(() => message);
        }

        /// <summary>
        /// Error method to call from CLAP; a 1 will be returned as the exit code if this is entered since an exception was thrown.
        /// </summary>
        /// <param name="context">Context provided with details.</param>
        [Error]
    #pragma warning disable CS3001 // Argument type is not CLS-compliant - needed for CLAP
        public static void Error(ExceptionContext context)
    #pragma warning restore CS3001 // Argument type is not CLS-compliant
        {
            new { context }.Must().NotBeNull();
<<<<<<< HEAD
            var typeRepresentationEqualityComparer = new VersionlessTypeRepresentationEqualityComparer();
=======
            var typeDescriptionComparer = new TypeComparer(TypeMatchStrategy.NamespaceAndName);
>>>>>>> f299d8dbc5dc7e0abcb0c85480e26493b239856a

            // change color to red
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            // parser exception or
            if (context.Exception is CommandLineParserException)
            {
                Console.WriteLine("Failure parsing command line arguments.  Run the exe with the 'help' command for usage.");
                Console.WriteLine("   " + context.Exception.Message);
            }
<<<<<<< HEAD
            else if ((globalTypeRepresentationsOfExceptionsToOmitStackTraceFrom ?? new TypeRepresentation[0]).Any(_ => typeRepresentationEqualityComparer.Equals(_, context.Exception.GetType().ToRepresentation())))
=======
            else if ((ExceptionTypeRepresentationsToOnlyPrintMessage ?? new TypeRepresentation[0]).Any(_ => typeDescriptionComparer.Equals(_, context.Exception.GetType().ToRepresentation())))
>>>>>>> f299d8dbc5dc7e0abcb0c85480e26493b239856a
            {
                Console.WriteLine("Failure during execution; configured to omit stack trace.");
                Console.WriteLine(string.Empty);
                Console.WriteLine("   " + context.Exception.Message);
            }
            else
            {
                Console.WriteLine("Failure during execution.");
                Console.WriteLine("   " + context.Exception.Message);
                Console.WriteLine(string.Empty);
                Console.WriteLine("   " + context.Exception);
                Its.Log.Instrumentation.Log.Write(context.Exception);
            }

            // restore color
            Console.WriteLine();
            Console.ForegroundColor = originalColor;
        }

        /// <summary>
        /// Help method to call from CLAP.
        /// </summary>
        /// <param name="helpText">Generated help text to display.</param>
        [Empty]
        [Help(Aliases = "h,?,-h,-help")]
        [Verb(Aliases = nameof(WellKnownConsoleVerb.Help), IsDefault = true)]
        public static void ShowUsage(string helpText)
        {
            new { helpText }.Must().NotBeNull();

            Console.WriteLine("   Usage");
            Console.Write("   -----");

            // strip out the usage info about help, it's confusing
            helpText = helpText.Split(new[] { Environment.NewLine }, StringSplitOptions.None).Skip(3).ToNewLineDelimited();
            Console.WriteLine(helpText);
            Console.WriteLine();
        }

        /// <summary>
        /// Runs common setup logic to prepare for and <see cref="Naos.Configuration" />, also will launch the debugger if the debug flag is provided.
        /// </summary>
        /// <param name="debug">A value indicating whether or not to launch the debugger.</param>
        /// <param name="environment">Optional environment name that will set the <see cref="Naos.Configuration" /> precedence instead of the default which is reading the App.Config value.</param>
        /// <param name="logWritingSettings">Optional <see cref="LogWritingSettings" /> to use instead of the default found in <see cref="Naos.Configuration" />.</param>
        /// <param name="configuredAndManagedLogProcessors">Optional set of pre-configured and externally managed <see cref="LogWriterBase" /> to use.</param>
        /// <param name="announcer">Optional announcer; DEFAULT is null which will go to <see cref="Console.WriteLine(string)" />.<see cref="Console.WriteLine(string)" />.</param>
        protected static void CommonSetup(bool debug, string environment = null, LogWritingSettings logWritingSettings = null, IReadOnlyCollection<LogWriterBase> configuredAndManagedLogProcessors = null, Action<string> announcer = null)
        {
<<<<<<< HEAD
            var launchTime = DateTime.UtcNow;
            var localAnnouncer = BuildPrefixingAnnouncer(announcer);
            localAnnouncer(Invariant($"Launched at {launchTime.ToLocalTime().TimeOfDay} on {launchTime.ToLocalTime().Date} (Local) | {launchTime.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)}Z (UTC)."));
            localAnnouncer(Invariant($"> Common Setup"));
=======
            var localAnnouncer = announcer ?? Console.WriteLine;
>>>>>>> f299d8dbc5dc7e0abcb0c85480e26493b239856a

            /*---------------------------------------------------------------------------*
             * Useful for launching the debugger from the command line and making sure   *
             * it is connected to the instance of the IDE you want to use.               *
             *---------------------------------------------------------------------------*/
            if (debug)
            {
<<<<<<< HEAD
                localAnnouncer(Invariant($"Debugger was set to be launched (debug=true option provide).{Environment.NewLine}{DefaultAnnouncementPadding}{DefaultAnnouncementPadding}- If the VisualStudio debugger menu is not shown check your 'Just-In-Time debugger' settings.{Environment.NewLine}{DefaultAnnouncementPadding}{DefaultAnnouncementPadding}- Go to (Visual Studio Menu Bar)->Tools->Options{Environment.NewLine}{DefaultAnnouncementPadding}{DefaultAnnouncementPadding}- then (Options Left Pane Navigation)->Debugging->Just-In-Time{Environment.NewLine}{DefaultAnnouncementPadding}{DefaultAnnouncementPadding}- then (Just-In-Time Debugging Settings on right pane)->Make sure the 'Managed' check box is checked."));
=======
>>>>>>> f299d8dbc5dc7e0abcb0c85480e26493b239856a
                Debugger.Launch();
            }

            /*---------------------------------------------------------------------------*
             * Setup deserialization logic for any use of Naos.Configuration reading      *
             * config files from the '.config' directory with 'environment' sub folders  *
             * the chain of responsibility is set in the App.config file using the       *
             * 'Naos.Configuration.Settings.Precedence' setting.  You can override the    *
<<<<<<< HEAD
             * way this is used by specifying a different directory for the config or     *
             * providing additional precedence values using                               *
=======
             * way this is used by specifying a different diretory for the config or     *
             * providing additonal precedence values using                               *
>>>>>>> f299d8dbc5dc7e0abcb0c85480e26493b239856a
             * ResetConfigureSerializationAndSetValues.                                  *
             *---------------------------------------------------------------------------*/
            if (!string.IsNullOrWhiteSpace(environment))
            {
<<<<<<< HEAD
                localAnnouncer(Invariant($"Set Config Precedence to: '{environment}'."));
=======
>>>>>>> f299d8dbc5dc7e0abcb0c85480e26493b239856a
                Config.SetPrecedence(environment, Config.CommonPrecedence);
            }

            /*---------------------------------------------------------------------------*
             * Initialize logging; this sets up Its.Log which is what gets used through- *
             * out the code.  All logging will also get sent through it.  This  can be   *
             * swapped out to send all Its.Log messages to another logging framework if  *
             * there is already one in place.                                            *
             *---------------------------------------------------------------------------*/
<<<<<<< HEAD
            var localLogProcessorSettings = logWritingSettings ?? Config.Get<LogWritingSettings>(new SerializerRepresentation(SerializationKind.Json, typeof(LoggingJsonSerializationConfiguration).ToRepresentation()));
            if (localLogProcessorSettings == null)
            {
                localAnnouncer(Invariant($"{DefaultAnnouncementPadding}- No LogProcessorSettings provided or found in config; using Null Object substitute."));
=======
            var localLogProcessorSettings = logWritingSettings ?? Config.Get<LogWritingSettings>(typeof(LoggingJsonConfiguration));
            if (localLogProcessorSettings == null)
            {
                localAnnouncer("No LogProcessorSettings provided or found in config; using Null Object susbstitue.");
>>>>>>> f299d8dbc5dc7e0abcb0c85480e26493b239856a
                localLogProcessorSettings = new LogWritingSettings();
            }

            LogWriting.Instance.Setup(localLogProcessorSettings, localAnnouncer, configuredAndManagedLogProcessors, errorCodeKeys: new[] { "__OBC_ErrorCode__" });
<<<<<<< HEAD
            localAnnouncer(Invariant($"< Common Setup"));
        }

        /// <summary>
        /// Prefixes the announcement using the provided announcer.
        /// </summary>
        /// <param name="announcement">The announcement.</param>
        /// <param name="announcer">Optional announcer; DEFAULT is Console.WriteLine.</param>
        /// <param name="padding">Optional padding to use; DEFAULT is '    '.</param>
        /// <param name="defaultPrefix">Optional prefix to use on announcements that have none; DEFAULT is hyphen/minus/'-'.</param>
        protected static void PrefixAnnounce(
            string announcement,
            Action<string> announcer = null,
            string padding = null,
            string defaultPrefix = null)
        {
            var prefix =
                (announcement.StartsWith(">") || announcement.StartsWith("<") || announcement.StartsWith("-") || announcement.StartsWith("!"))
                    ? string.Empty
                    : defaultPrefix ?? DefaultAnnouncementPrefix;

            var prefixed = (padding ?? DefaultAnnouncementPadding) + prefix + announcement;
            (announcer ?? Console.WriteLine)(prefixed);
        }

        /// <summary>
        /// Builds an announcer wrapper that will call <see cref="PrefixAnnounce"/> with the announcement and provided values.
        /// </summary>
        /// <param name="announcer">Optional announcer; DEFAULT is Console.WriteLine.</param>
        /// <param name="padding">Optional padding to use; DEFAULT is '    '.</param>
        /// <param name="defaultPrefix">Optional prefix to use on announcements that have none; DEFAULT is hyphen/minus/'-'.</param>
        /// <returns>An announcer that does the prefixing.</returns>
        protected static Action<string> BuildPrefixingAnnouncer(
            Action<string> announcer = null,
            string padding = null,
            string defaultPrefix = null)
        {
            void ResultAction(
                string _)
                => PrefixAnnounce(_, announcer, padding, defaultPrefix);

            return ResultAction;
=======

>>>>>>> f299d8dbc5dc7e0abcb0c85480e26493b239856a
        }

        /// <summary>
        /// Build and write standard telemetry items to  <see cref="Its.Log" />.
        /// </summary>
        protected static void WriteStandardTelemetry()
        {
            /*---------------------------------------------------------------------------*
             * Write telemetry:  Log telemetry general records                           *
             *---------------------------------------------------------------------------*/
            var dateTimeOfSampleInUtc = DateTime.UtcNow;
            var machineDetails = DomainFactory.CreateMachineDetails();
            var processDetails = DomainFactory.CreateProcessDetails();

            var processDirectory = Path.GetDirectoryName(processDetails.FilePath) ?? throw new InvalidOperationException("Could not get directory from process file path: " + processDetails.FilePath);
            var processSiblingAssemblies = Directory.GetFiles(processDirectory, "*", SearchOption.AllDirectories)
                .Where(_ => _.ToLowerInvariant().EndsWith(".exe") || _.ToLowerInvariant().EndsWith(".dll")).Select(_ =>
                {
                    try
                    {
                        return AssemblyDetails.CreateFromFile(_);
                    }
                    catch (Exception)
                    {
                        return new AssemblyDetails(Path.ChangeExtension(Path.GetFileName(_), string.Empty), Version.Parse("1.0.0.0").ToString(), _, "UNKNOWN");
                    }
                })
                .ToList();

            var diagnosticsTelemetry = new DiagnosticsTelemetry(dateTimeOfSampleInUtc, machineDetails, processDetails, processSiblingAssemblies);
            Its.Log.Instrumentation.Log.Write(() => diagnosticsTelemetry);
        }

        /// <summary>
        /// Masks a string to be printed, very useful for things like passwords or certificate keys.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <param name="percentageOfStringToMask">Optional percentage of string to leave; e.g. 20, 50, etc. (must be between 1-99); default is 70.</param>
        /// <returns>Masked string.</returns>
        protected static string MaskString(string input, int percentageOfStringToMask = 70)
        {
            new { percentageOfStringToMask }.Must().BeInRange(1, 99);

            var localInput = input ?? string.Empty;
            int indexToMaskUntil = (int)(localInput.Length * (percentageOfStringToMask / 100d));
            var maskedString = new string('*', indexToMaskUntil) + string.Join(string.Empty, localInput.Skip(indexToMaskUntil));
            return maskedString;
        }

        /// <summary>
        /// Prints the arguments as provided via an anonymous object. e.g. PrintArguments(new { argumentOne, argumentTwo, maskedArgumentThree = MaskString(argumentThree), totalDays = argumentFour.TotalDays }, nameof(MyMethod));
        /// </summary>
        /// <example>PrintArguments(new { argumentOne, argumentTwo, maskedArgumentThree = MaskString(argumentThree), totalDays = argumentFour.TotalDays }, nameof(MyMethod));</example>
        /// <param name="anonymousObjectWithArguments">Object to reflect over properties of.</param>
        /// <param name="description">Description of the event (DEFAULT is method name called).</param>
        /// <param name="method">Optional name of method being called, if null then it will construct a <see cref="StackTrace" /> to retrieve it; this takes about 10-15 milliseconds so it's not free but is relatively cheap to have a smaller mouth to feed.</param>
        /// <param name="announcer">Optional announcer; DEFAULT is null which will go to <see cref="Console.WriteLine(string)" />.<see cref="Console.WriteLine(string)" />.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "object", Justification = "Prefer this name for clarity.")]
        protected static void PrintArguments(object anonymousObjectWithArguments = null, string description = null, string method = null, Action<string> announcer = null)
        {
<<<<<<< HEAD
            var localAnnouncer = BuildPrefixingAnnouncer(announcer);
=======
            var localAnnouncer = announcer ?? Console.WriteLine;
>>>>>>> f299d8dbc5dc7e0abcb0c85480e26493b239856a
            var localMethod = method ?? new StackTrace().GetFrame(1).GetMethod().Name;
            var lines = new List<string>();

            var propertyInfos = anonymousObjectWithArguments?.GetType().GetProperties(BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public).ToList();
            var localFirstLine = Invariant($"Called '{localMethod}' with no provided arguments");

            if (propertyInfos != null && propertyInfos.Any())
            {
                localFirstLine = Invariant($"Called '{localMethod}' with the following arguments:");

                int longestLeftOffset = 3 + propertyInfos.Max(_ => _.Name.Length);

                foreach (var propertyInfo in propertyInfos)
                {
                    var value = propertyInfo.GetValue(anonymousObjectWithArguments) ?? "<null>";
                    var propertyName = propertyInfo.Name;
                    var paddingSize = longestLeftOffset - propertyName.Length;
                    var padding = new string(' ', paddingSize);
                    var line = Invariant($"{padding}{propertyName}: {value}");
                    lines.Add(line);
                }
            }

            lines.Add(string.Empty);

            localAnnouncer(string.IsNullOrWhiteSpace(description) ? localFirstLine : description);
            lines.ForEach(_ => localAnnouncer(_));
        }

        /// <summary>
        /// Parses a <see cref="TimeSpan" /> from the provided text in expected format; dd:hh:mm (double digit day:hour:minute).
        /// </summary>
        /// <param name="textToParse">Text to parse to a <see cref="TimeSpan" />.</param>
        /// <returns>Parsed <see cref="TimeSpan" />.</returns>
        protected static TimeSpan ParseTimeSpanFromDayHourMinuteColonDelimited(string textToParse)
        {
            var argException = new ArgumentException("Value: " + (textToParse ?? string.Empty) + " isn't a valid time, please use format dd:hh:mm.", textToParse);
            if (string.IsNullOrEmpty(textToParse))
            {
                throw argException;
            }

            var split = textToParse.Split(':');
            if (split.Length != 3)
            {
                throw argException;
            }

            var daysRaw = split[0];
            if (!int.TryParse(daysRaw, out int days))
            {
                throw argException;
            }

            var hoursRaw = split[1];
            if (!int.TryParse(hoursRaw, out int hours))
            {
                throw argException;
            }

            var minutesRaw = split[2];
            if (!int.TryParse(minutesRaw, out int minutes))
            {
                throw argException;
            }

            return new TimeSpan(days, hours, minutes, 0);
        }
    }

    /// <summary>
    /// Example of how to extend the base class to add your custom functionality.  It's recommeneded that each method take
    /// optional environment name AND debug boolean paramters and then call the <see cref="ConsoleAbstractionBase.CommonSetup" /> but not necessary.
    /// The common setup also allows for provided the <see cref="LogWritingSettings" /> directly instead of the default
    /// loading from <see cref="Naos.Configuration" />.
    /// </summary>
    public class ExampleConsoleAbstraction : ConsoleAbstractionBase
    {
        /// <summary>
        /// Example of a custom data processing job that might need to be run as a cron job.
        /// </summary>
        /// <param name="debug">A value indicating whether or not to launch the debugger.</param>
        /// <param name="environment">Optional environment name that will set the <see cref="Naos.Configuration" /> precedence instead of the default which is reading the App.Config value.</param>
        /// <param name="filePathToProcess">Example of a directory that needs to be checked for files to process.</param>
        [Verb(Aliases = nameof(WellKnownConsoleVerb.Example), Description = "Example of a custom data processing job that might need to be run as a cron job.")]
        public static void Example(
            [Aliases("")] [Description("Launches the debugger.")] [DefaultValue(false)] bool debug,
            [Aliases("")] [Description("Sets the Naos.Configuration precedence to use specific settings.")] [DefaultValue(null)] string environment,
            [Required] [Aliases("")] [Description("Example of a directory that needs to be checked for files to process.")] string filePathToProcess)
        {
            /*---------------------------------------------------------------------------*
             * Normally this would just be done from the Naos.Configuration file but the  *
             * we're overriding to only use the Console for demonstration purposes.      *
             *---------------------------------------------------------------------------*/
            var logProcessorSettingsOverride = new LogWritingSettings(new[]
            {
                    new ConsoleLogConfig(
                        new Dictionary<LogItemKind, IReadOnlyCollection<string>>(), // all
                        new Dictionary<LogItemKind, IReadOnlyCollection<string>> {{LogItemKind.Exception, null}}, // all Exceptions
                        new Dictionary<LogItemKind, IReadOnlyCollection<string>> // Strings and Objects from ItsLogEntryPosted
                        {
                            {LogItemKind.String, new[] {LogItemOrigin.ItsLogEntryPosted.ToString()}},
                            {LogItemKind.Object, new[] {LogItemOrigin.ItsLogEntryPosted.ToString()}},
                        }),
                });

            /*---------------------------------------------------------------------------*
             * Any method should run this logic to debug, setup config & logging, etc.   *
             *---------------------------------------------------------------------------*/
            CommonSetup(debug, environment, logProcessorSettingsOverride);

            /*---------------------------------------------------------------------------*
             * Any method should run this logic to write telemetry info to the log.      *
             *---------------------------------------------------------------------------*/
<<<<<<< HEAD
            // WriteStandardTelemetry(); // removing this for now because it's not being collected well enough
=======
            WriteStandardTelemetry();
>>>>>>> f299d8dbc5dc7e0abcb0c85480e26493b239856a

            /*---------------------------------------------------------------------------*
             * This is not necessary but often very useful to print out the arguments.   *
             *---------------------------------------------------------------------------*/
            PrintArguments(new { filePathToProcess, environment });

            Its.Log.Instrumentation.Log.Write(() => Invariant($"Processed files at: {filePathToProcess}"));
        }
    }
}