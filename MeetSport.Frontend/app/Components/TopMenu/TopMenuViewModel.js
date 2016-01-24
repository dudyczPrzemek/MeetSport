function TopMenuViewModel() {
    var self = this;

    self.viewModelsLogged = ko.observableArray([{compName: "Aktualnosci", desc: "Aktualności"}, 
        { compName: "YourEvents", desc: "Twoje wydarzenia" }, { compName: "EventSearching", desc: "Wyszukaj" },
        { desc: "Wyloguj", handler: "logout" }]);

    self.viewModelsNotLogged = ko.observableArray([]);

    self.loggedIn = ko.computed(authManager.isLogged);

    self.logout = function () {
        authManager.clearToken();
        userData.Clear();
        app.current("Login-nc");
    }
}

