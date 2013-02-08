(function (window) {

    var console = {
        firebug: {
            /// <summary>The Firebug version</summary>
            /// <returns type="String" />
        },
        log: function () {
            /// <summary>
            ///     Writes a message to the console. You may pass as many arguments as you'd like, and they will be joined together in a space-delimited line.
            /// </summary>
            /// <param name="object" type="Object">
            ///     The object to debug
            /// </param>
            /// <param name="objectN" type="Object" optional="true" parameterArray="true">
            ///     More objects to debug
            /// </param>
            /// <returns type="undefined" />
        },
        debug: function () {
            /// <summary>
            ///     Writes a message to the console, including a hyperlink to the line where it was called.
            /// </summary>
            /// <param name="object" type="Object">
            ///     The object to debug
            /// </param>
            /// <param name="objectN" type="Object" optional="true" parameterArray="true">
            ///     More objects to debug
            /// </param>
            /// <returns type="undefined" />
        },
        info: function () {
            /// <summary>
            ///     Writes a message to the console with the visual "info" icon and color coding and a hyperlink to the line where it was called.
            /// </summary>
            /// <param name="object" type="Object">
            ///     The object to inspect
            /// </param>
            /// <param name="objectN" type="Object" optional="true" parameterArray="true">
            ///     More objects
            /// </param>
            /// <returns type="undefined" />
        },
        warn: function () {
            /// <summary>
            ///     Writes a message to the console with the visual "warning" icon and color coding and a hyperlink to the line where it was called.
            /// </summary>
            /// <returns type="undefined" />
            /// <param name="object" type="Object">
            ///     The object to warn
            /// </param>
            /// <param name="objectN" type="Object" optional="true" parameterArray="true">
            ///     More objects to warn
            /// </param>
        },
        error: function () {
            /// <summary>
            ///     Writes a message to the console with the visual "error" icon and color coding and a hyperlink to the line where it was called.
            /// </summary>
            /// <returns type="undefined" />
            /// <param name="object" type="Object">
            ///     The object to display as the error
            /// </param>
            /// <param name="objectN" type="Object" optional="true" parameterArray="true">
            ///     More objects to display as the error
            /// </param>
        },
        assert: function () {
            /// <summary>
            ///     Tests that an expression is true. If not, it will write a message to the console and throw an exception.
            /// </summary>
            /// <returns type="undefined" />
            /// <param name="expression" type="Expression">
            ///     The expression to test
            /// </param>
            /// <param name="expressionN" type="Expression" optional="true" parameterArray="true">
            ///     More expressions to test
            /// </param>
        },
        dir: function (object) {
            /// <summary>
            ///     Prints an interactive listing of all properties of the object. This looks identical to the view that you would see in the DOM tab.
            /// </summary>
            /// <returns type="undefined" />
            /// <param name="object" type="Object">
            ///     The object to list
            /// </param>
        },
        dirxml: function (node) {
            /// <summary>
            ///     Prints the XML source tree of an HTML or XML element. This looks identical to the view that you would see in the HTML tab. You can click on any node to inspect it in the HTML tab.
            /// </summary>
            /// <returns type="undefined" />
            /// <param name="node" type="object" domElement="true">
            ///     The node to inspect
            /// </param>
        },
        trace: function () {
            /// <summary>
            ///     Prints an interactive stack trace of JavaScript execution at the point where it is called.
            ///     The stack trace details the functions on the stack, as well as the values that were passed as arguments to each function. You can click each function to take you to its source in the Script tab, and click each argument value to inspect it in the DOM or HTML tabs.
            /// </summary>
            /// <returns type="undefined" />
        },
        group: function () {
            /// <summary>
            ///     Writes a message to the console and opens a nested block to indent all future messages sent to the console. Call console.groupEnd() to close the block.
            /// </summary>
            /// <returns type="undefined" />
            /// <param name="object" type="Object">
            ///     The object to log
            /// </param>
            /// <param name="objectN" type="Object" optional="true" parameterArray="true">
            ///     More objects to log
            /// </param>
        },
        groupCollapsed: function () {
            /// <summary>
            ///     Like console.group(), but the block is initially collapsed.
            /// </summary>
            /// <returns type="undefined" />
            /// <param name="object" type="Object">
            ///     The object to log
            /// </param>
            /// <param name="objectN" type="Object" optional="true" parameterArray="true">
            ///     More objects to log
            /// </param>
        },
        groupEnd: function () {
            /// <summary>
            ///     Closes the most recently opened block created by a call to console.group() or console.groupEnd()
            /// </summary>
            /// <returns type="undefined" />
        },
        time: function (name) {
            /// <summary>
            ///     Creates a new timer under the given name. Call console.timeEnd(name) with the same name to stop the timer and print the time elapsed..
            /// </summary>
            /// <returns type="undefined" />
            /// <param name="name" type="String">
            ///     The name of the timer
            /// </param>
        },
        timeEnd: function (name) {
            /// <summary>
            ///     Stops a timer created by a call to console.time(name) and writes the time elapsed.
            /// </summary>
            /// <returns type="undefined" />
            /// <param name="name" type="String">
            ///     The name of the timer
            /// </param>
        },
        profile: function (title) {
            /// <summary>
            ///     Turns on the JavaScript profiler.
            /// </summary>
            /// <returns type="undefined" />
            /// <param name="title" optional="true" type="String">
            ///     The text to be printed in the header of the profile report.
            /// </param>
        },
        profileEnd: function () {
            /// <summary>
            ///     Turns off the JavaScript profiler and prints its report.
            /// </summary>
            /// <returns type="undefined" />
        },
        count: function (title) {
            /// <summary>
            ///     Writes the number of times that the line of code where count was called was executed.
            /// </summary>
            /// <returns type="undefined" />
            /// <param name="title" optional="true" type="String">
            ///     The title to print in addition to the number of the count
            /// </param>
        },
        exception: function () {
            /// <summary>
            ///     Prints an error message together with an interactive stack trace of JavaScript execution at the point where the exception occurred.
            /// </summary>
            /// <returns type="undefined" />
            /// <param name="errorObject" type="Exception">
            ///     The JavaScript exception object to display
            /// </param>
            /// <param name="errorObjectN" optional="true" type="Exception">
            ///     Other JavaScript exception objects to display
            /// </param>
        }
        // The following functions are automatically included with JS IntelliSense in VS 2010.
        // They have been commented out.
        //, 
        //        hasOwnProperty: function () {
        //            /// <summary>n/a</summary>
        //            /// <returns type="Boolean" />
        //        },
        //        isPrototypeOf: function () {
        //            /// <summary>n/a</summary>
        //            /// <param name="object" type="object" >
        //            /// <returns type="Boolean" />
        //        },
        //        propertyIsEnumerable: function () {
        //            /// <summary>n/a</summary>
        //            /// <param name="property" type="String" >
        //            /// <returns type="Boolean" />
        //        },
        //        toLocaleString: function () {
        //            /// <summary>n/a</summary>
        //            /// <returns type="String" />
        //        },
        //        toString: function () {
        //            /// <summary>n/a</summary>
        //            /// <returns type="String" />
        //        },
        //        valueOf: function () {
        //            /// <summary>n/a</summary>
        //            /// returns type="Number" />
        //        }
    };

    window.console = console;

} (window));
