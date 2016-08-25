define(["knockout", "jquery", "jquery-ui", "text!./game.html", "require"], function (ko, $, $$, gameTemplate, require) {


    var GameViewModel = function () {

        var self = this;

        self.id = ko.observable();


        return self;
    };

    return { viewModel: GameViewModel, template: gameTemplate };
});