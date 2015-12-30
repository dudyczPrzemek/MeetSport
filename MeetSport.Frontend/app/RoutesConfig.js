routing.init({
    loginComponentName: "login-nc",
    defaultViewName: "WynikiNaZywo",
    mappings: [
        { view: "Login", component: "login-nc" },
        { view: "Zlecenia", component: "TaskList-nc" },
        { view: "Dodaj", component: "AddTask-nc" },
        { view: "Detale", component: "TaskDetail-nc" },
        { view: "WynikiNaZywo", component: "LiveScore-nc" },
        { view: "EventMaking", component: "EventMaking-nc" }
    ]
});