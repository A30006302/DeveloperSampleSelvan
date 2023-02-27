import React, { useState } from "react";
import './LoginForm.css';

const LoginForm = (props) => {
	const [user, setUser] = useState("");
	const [password, setPassword] = useState("");
	const handleSetUser = (e) => setUser(e.target.value);
	const handleSetPassword = (e) => setPassword(e.target.value);
	const handleSubmit = (event) =>{
		event.preventDefault();

		props.onSubmit({
			login: user,
			password: password,
		});
	}

	return (
		<form className="form">
			<h1>Login</h1>
			<label htmlFor="name">Name</label>
			<input type="text" id="name" value={user} onChange={handleSetUser} />
			<label htmlFor="password">Password</label>
			<input type="password" id="password" value={password} onChange={handleSetPassword} />
			<button type="submit" onClick={handleSubmit}>Continue</button>
		</form>
	)
}

export default LoginForm;