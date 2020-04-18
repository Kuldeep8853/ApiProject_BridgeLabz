import React, { Component } from 'react';
import { Button } from 'reactstrap';
import updateEmployee from '../services/Controller'

export class UpdateEmployee extends Component {

    constructor(id) {
        super(id);
        this.state = {
            FirstName: '',
            LastName: '',
            PhoneNumber: '',
            Email: '',
            PassWord: ''
        }
    }
    handleFNameChange = (event) => {
        const FirstName = event.target.value;
        this.setState({
            FirstName: FirstName
        });
        console.log("FirstName", this.state.FirstName);
    }

    handleLNameChange = (event) => {
        const LastName = event.target.value;
        this.setState({
            LastName: LastName
        });
        console.log("LastName", this.state.LastName);
    }

    handlePhoneNumberChange = (event) => {
        const PhoneNumber = event.target.value;
        this.setState({
            PhoneNumber: PhoneNumber
        });
        console.log("PhoneNumber", this.state.PhoneNumber);
    }

    handleEmailChange = (event) => {
        const Email = event.target.value;
        this.setState({
            Email: Email
        });
        console.log("Email", this.state.Email);
    }

    handlepasswordChange = (event) => {
        const PassWord = event.target.value;
        this.setState({
            PassWord: PassWord
        })
        console.log("PassWord", this.state.PassWord);
    }

    handleUpadate=(id)=> {
            var data = JSON.stringify
                ({
                    FirstName: this.state.FirstName,
                    LastName: this.state.LastName,
                    PhoneNumber: this.state.PhoneNumber,
                    Email: this.state.Email,
                    PassWord: this.state.PassWord
                })
                updateEmployee(id, data)
                .then(response => response.json())
                .then((result) => {  
                    alert(result);
                },
                    (error) => {
                        alert('Failed');
                    })
    }

    render() {
        return (
            <div className="App">
                <div className="Registration-div"><h2>Update Employee</h2></div>
                <div className="main-Text-div">
                    <div className="FName-div">
                        <input type="text" className="input-fname-text" placeholder="Enter your first name" onChange={this.handleFNameChange} />
                    </div>
                    <div className="LName-div">
                        <input type="text" className="input-lname-text" placeholder="Enter your last name" onChange={this.handleLNameChange} />
                    </div>
                    <div className="PhoneNumber-div">
                        <input type="text" className="input-PhoneNumber-text" placeholder="Enter your PhoneNumber" onChange={this.handlePhoneNumberChange} />
                    </div>
                    <div className="email-div">
                        <input type="email" className="input-email-text" placeholder="Enter your email" onChange={this.handleEmailChange} />
                    </div>
                    <div className="password-div">
                        <input type="password" className="input-password-text" placeholder="Enter password" onChange={this.handlepasswordChange} />
                    </div>
                    <div className="app-button">
                        <Button onClick={this.handleUpadate(this.state.id)} color="success" block>Update</Button>
                    </div>
                </div>
            </div>
        ); 
    }
}
export default UpdateEmployee;