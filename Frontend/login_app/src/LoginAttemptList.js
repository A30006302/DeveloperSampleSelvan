import React, { useState } from "react";
import "./LoginAttemptList.css";

// developer selvan seeman
// 02/26/2023
const LoginAttempt = (props) => <>{React.Children.toArray(
						props.attempts
						.filter(function (item) {
							return item.user.includes(props.filter) // filter and return a new array
						  })						
						.map((item, i) => <li>{item.user}</li>))}</>;

const LoginAttemptList = (props) => {
	const [filter, setFilter] = useState("");
	const handleSetFilter = (e) => setFilter(e.target.value);
	
	return (
		<div className="Attempt-List-Main">
			<p>Recent activity</p>
			<input type="input" placeholder="Filter..." value={filter} onChange={handleSetFilter} />
			<ul className="Attempt-List">
			<LoginAttempt attempts={props.attempts} filter={filter}></LoginAttempt>
			</ul>
		</div>
)};

export default LoginAttemptList;