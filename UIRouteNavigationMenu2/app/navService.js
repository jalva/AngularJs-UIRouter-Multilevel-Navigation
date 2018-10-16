
// the nav service (fetches the json)
app.factory('navService', function ($http, $q) {
    return {
        getNavItems: function (level) {
            return $q(function (resolve, reject) {
                var navData = sessionStorage.getItem('navData');
                if (!navData) {
                    $http.get('/api/uinavigation')
                        .then(function(data){
                            navData = data.data;
                            sessionStorage.setItem('navData', JSON.stringify(navData));
                            resolve(navData);
                        });
                }
                else {
                    resolve(JSON.parse(navData));
                }

            });
        }
    }
});