/// <binding Clean='clean' ProjectOpened='default' />
// include gulp
var gulp = require("gulp");
var autoprefixer = require("gulp-autoprefixer");
var ngTemplatecache = require("gulp-angular-templatecache");
var ngAnnotate = require("gulp-ng-annotate");
var sass = require("gulp-sass");
var minifyCss = require("gulp-minify-css");
var concat = require("gulp-concat");
var plumber = require("gulp-plumber");
var rename = require("gulp-rename");
var uglify = require("gulp-uglify");
var del = require("del");
var runSequence = require("run-sequence");

// config
var config = {
    dest: "./build"
}

// default gulp task
gulp.task('default', function () {
    runSequence('build', 'watch');
});

gulp.task("watch", function () {
    // watch for Template changes
    gulp.watch("./app/**/*.html", ["templates"]);
    // watch for JS changes
    gulp.watch("./app/**/*.js", ["bundle-app"]);
    // watch for Less changes
    gulp.watch("./sass/*.scss", ["minify-css"]);
});

gulp.task("build", [
  "bundle-vendor-scripts",
  "templates",
  "bundle-app",
  "minify-css"
]);

// Clean
gulp.task("clean", function () {
    del([config.dest + "/**/*"]);
});

// Angular html templates
gulp.task("templates", function () {
    return gulp.src("./app/**/*.html")
      .pipe(plumber())
      //.pipe(minifyHtml({ comments: false, empty: true, spare: true, quotes: true }))
      .pipe(ngTemplatecache({ module: 'app' }))
      //.pipe(uglify())
      .pipe(gulp.dest(config.dest));
});


// Angular scripts
gulp.task("bundle-app", function () {
    return gulp.src([
        "./app/app.module.js", // main app module
        "./app/**/*.js" // all angular js
    ])
      .pipe(plumber())
      .pipe(concat("app.js"))
      .pipe(ngAnnotate())
      .pipe(gulp.dest(config.dest));
    // .pipe(stripDebug())
    // .pipe(uglify())
    // .pipe(rename({ suffix: '.min' }))
    // .pipe(gulp.dest(dest));
});

// Bundle Vendor Js Scripts
var vendorJsSrc = [
    "./node_modules/angular/angular.min.js",
    "./node_modules/angular-animate/angular-animate.min.js",
    "./node_modules/angular-ui-router/release/angular-ui-router.min.js",
    "./node_modules/angular-local-storage/dist/angular-local-storage.min.js",
    "./node_modules/angular-base-apps/dist/js/base-apps.min.js",
    "./node_modules/angular-strap/dist/angular-strap.min.js",
    "./node_modules/angular-strap/dist/angular-strap.tpl.min.js",
    "./node_modules/angular-loading-bar/build/loading-bar.min.js",
    "./node_modules/fastclick/lib/fastclick.js",
    "./node_modules/hammerjs/hammer.min.js",
    "./scripts/lodash.min.js"
];
gulp.task("bundle-vendor-scripts", function () {
    return gulp.src(vendorJsSrc)
      .pipe(plumber())
      .pipe(concat("vendor-scripts.js"))
      .pipe(gulp.dest(config.dest));
    // .pipe(stripDebug())
    // .pipe(uglify())
    // .pipe(rename({ suffix: '.min' }))
    // .pipe(gulp.dest(config.dest));
});

// Bundle Sass
var appCssSrc = [
    "./node_modules/angular-base-apps/dist/css/base-apps.css",
    "./node_modules/angular-loading-bar/build/loading-bar.min.css",
    "./sass/main.scss"
];
gulp.task("minify-css", function () {
    return gulp.src(appCssSrc)
      .pipe(plumber())
      .pipe(sass())
      .pipe(concat("app.css"))
      .pipe(autoprefixer("last 2 versions"))
      .pipe(minifyCss({ advanced: false }))
      .pipe(gulp.dest(config.dest));
    // .pipe(minifyCss({ advanced: false }))
    // .pipe(rename({ suffix: '.min' }))
    // .pipe(gulp.dest(config.dest + '/css'));
});