routing.init({
    loginComponentName: "login-nc",
    defaultViewName: "Aktualnosci",
    mappings: [
        { view: "Login", component: "login-nc" },
        { view: "Zlecenia", component: "TaskList-nc" },
        { view: "Dodaj", component: "AddTask-nc" },
        { view: "Detale", component: "TaskDetail-nc" },
        { view: "WynikiNaZywo", component: "LiveScore-nc" },
        { view: "EventMaking", component: "EventMaking-nc" },
        { view: "EventSearching", component: "EventSearching-nc" },
        { view: "About", component: "About-nc" },
        { view: "Contact", component: "Contact-nc" },
        { view: "Aktualnosci", component: "Aktualnosci-nc" },
        { view: "Greetings", component: "Greetings-nc" },
        { view: "EventInfo", component: "EventInfo-nc"}
    ]
});