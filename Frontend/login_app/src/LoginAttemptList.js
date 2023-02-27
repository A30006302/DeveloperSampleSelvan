import React from "react";
import "./LoginAttemptList.css";

const LoginAttempt = (props) => <>{React.Children.toArray(
						props.attempts.map((item, i) => <li>{item.user}</li>))}</>;

const LoginAttemptList = (props) => (
		<div className="Attempt-List-Main">
			<p>Recent activity</p>
			<input type="input" placeholder="Filter..." />
			<ul className="Attempt-List">
			<LoginAttempt attempts={props.attempts}></LoginAttempt>
			</ul>
		</div>
);


export default LoginAttemptList;