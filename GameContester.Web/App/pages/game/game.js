define(["knockout", "jquery", "jquery-ui", "text!./game.html", "require"], function (ko, $, $$, gameTemplate, require) {


    var GameViewModel = function () {

        var self = this;

        self.code = ko.observable("");
        self.sendcode = function ()
        {
            var codeCompiler = {
              Code:  $('#Code').val()
            };
            $.ajax({
                url: "http://localhost:51952/api/game/sendcode",
                contentType: 'application/x-www-form-urlencoded',
                type: "POST",
                data: codeCompiler,
                success: function (data) {
                    console.log(data);
                },
                error: function (data) {
                    console.log(data);
                    
                }
            });
        }


        return self;
    };

    return { viewModel: GameViewModel, template: gameTemplate };
});