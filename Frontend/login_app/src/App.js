import React, { useState } from "react";
import './App.css';
import LoginForm from './LoginForm';
import LoginAttemptList from './LoginAttemptList';

// developer selvan seeman
// 02/26/2023
const App = () => {
    const [loginAttempts, setLoginAttempts] = useState([]);

    return (
        <div className="App">
            <LoginForm onSubmit={({ login, password }) => setLoginAttempts(loginAttempts => [...loginAttempts, { "user": login, "password": password }])} />
            <LoginAttemptList attempts={loginAttempts} />
        </div>
    );
};

export default App;