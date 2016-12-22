$data.EntityContext.prototype.prepareRequest = function (r) {
    r.headers["Authorization"] = "Bearer " + authManager.getToken();
};