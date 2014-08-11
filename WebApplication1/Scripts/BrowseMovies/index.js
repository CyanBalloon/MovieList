$(document).ready(function () {
    var omdb = new omdbApi();

    $("[id^='moviecontainer']").hover(function () {
        //hover in
        var movieId = $(this).attr('id').split('-')[1];
        $("#description-" + movieId)
            .html(omdb.getMovieDescription(movieId))
            .show();
    }, function () {
        //hover out
        var movieId = $(this).attr('id').split('-')[1];
        $("#description-" + movieId)
            .hide();
    });
});