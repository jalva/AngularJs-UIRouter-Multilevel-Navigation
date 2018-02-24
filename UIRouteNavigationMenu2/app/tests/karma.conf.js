// Karma configuration
// Generated on Wed Mar 22 2017 14:54:36 GMT-0400 (Eastern Daylight Time)


module.exports = function (config) {

    config.set({


        // base path that will be used to resolve all patterns (eg. files, exclude)

        basePath: '../..',



        // frameworks to use

        // available frameworks: https://npmjs.org/browse/keyword/karma-adapter

        frameworks: ['jasmine'],



        // list of files / patterns to load in the browser

        files: [
            'scripts/angular.js',
            'scripts/angular-mocks.js',
            'scripts/angular-ui-router1.0.0-beta3.js',
            //'scripts/angular-cookies.js',
            //'scripts/angular-resource.min.js',
            //'scripts/ui-bootstrap-tpls-0.10.0.js',
            //'scripts/ui-router-visualizer3.1.3.js',
            'app/components/navMenu/app.js',
            'app/components/navMenu/nav-menu.component.js',
            'app/components/navMenu/navService.js',

            'app/tests2/**/*.js',

        ],



        // list of files to exclude

        exclude: [
        ],



        // preprocess matching files before serving them to the browser

        // available preprocessors: https://npmjs.org/browse/keyword/karma-preprocessor

        preprocessors: {
        },



        // test results reporter to use

        // possible values: 'dots', 'progress'

        // available reporters: https://npmjs.org/browse/keyword/karma-reporter

        reporters: ['spec'],



        // web server port

        port: 9876,



        // enable / disable colors in the output (reporters and logs)

        colors: true,



        // level of logging

        // possible values: config.LOG_DISABLE || config.LOG_ERROR || config.LOG_WARN || config.LOG_INFO || config.LOG_DEBUG

        logLevel: config.LOG_INFO,



        // enable / disable watching file and executing tests whenever any file changes

        autoWatch: false,


        // start these browsers

        // available browser launchers: https://npmjs.org/browse/keyword/karma-launcher

        browsers: ['Chrome'],



        // Continuous Integration mode

        // if true, Karma captures browsers, runs the tests and exits

        singleRun: true,


        // Concurrency level

        // how many browser should be started simultaneous

        concurrency: Infinity
    })
}
