app.config(function($routeProvider) {
    $routeProvider
        .when("/", {
            templateUrl: "../views/Home.html",
            controller: "HomeController"
        })

        .when("/lancamento", {
            templateUrl: "../views/LancarPontos.html",
            controller: "LancarPontosController"
        })

        .when("/resultados", {
            templateUrl: "../views/VerResultados.html",
            controller: "VerResultadosController"
        })

        .otherwise({ redirectTo: "/" });
});
