function API(apiName, apiDefinition) {

    function handleLogOut() {
        toastr.error("Zostałeś wylogowany!", "Błąd");
        cache.ClearAll();
        routing.refresh();
    }

    function handleStandardError(jqXHR, exception) {
        if (jqXHR.status === 401) {
            handleLogOut();
            return true;
        }
        return false;
    }

    this.api = $data.define(apiName, apiDefinition);

    this.api.setStore("default", {
        provider: "webApi",
        dataSource: "/api/" + apiName
    });

    this.query = function (filterFunc, params, callback, errorCallback) {
        this.api.query(filterFunc, params)
            .then(function (items) {
                callback(items);
            })
            .fail(errorCallback || handleStandardError);
    }
}