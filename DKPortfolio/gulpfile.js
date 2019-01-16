/// <binding AfterBuild='default' />
var gulp = require('gulp');
sass = require('gulp-sass');

gulp.task('build-css', function () {
    return gulp
        .src('./wwwroot/sass/*.scss')
        .pipe(sass())
        .pipe(gulp.dest('./wwwroot/css'));
                
});
gulp.task('default', ['build-css']);