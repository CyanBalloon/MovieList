function omdbApi() {
    var apiUrl = globalVariables.APIURL;
    var omdbData = null;

    this.getMovieDescription = function (movieId) {
        var getMovieUrl = apiUrl + "movie/" + movieId + "?" + globalVariables.APIKEY;
        $.ajax({
            dataType: "json",
            type: 'GET',
            async: false,
            url: getMovieUrl,
            success: function (data) {
                omdbData = data;
            }
        });
        return omdbData.overview;
    };
}