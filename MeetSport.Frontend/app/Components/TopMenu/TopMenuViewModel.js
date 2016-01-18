function TopMenuViewModel() {
    var self = this;

    self.viewModelsLogged = ko.observableArray(["Aktualnosci", "EventMaking", "EventSearching"]);

    self.viewModelsNotLogged = ko.observableArray([]);

    self.loggedIn = ko.computed(authManager.isLogged);
}

