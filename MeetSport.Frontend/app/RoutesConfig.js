routing.init({
    loginComponentName: "login-nc",
    defaultViewName: "Aktualnosci",
    mappings: [
        { view: "Login", component: "login-nc" },
        { view: "EventMaking", component: "EventMaking-nc" },
        { view: "EventSearching", component: "EventSearching-nc" },
        { view: "Aktualnosci", component: "Aktualnosci-nc" },
        { view: "EventInfo", component: "EventInfo-nc" },
        { view: "YourEvents", component: "YourEvents-nc" },
        { view: "LiveEvents", component: "LiveEvents-nc" },
        { view: "Transmission", component: "Transmission-nc" },
        { view: "Greetings", component: "Greetings-nc" },
        { view: "OwnerEventInfo", component: "OwnerEventInfo-nc"}
    ]
});