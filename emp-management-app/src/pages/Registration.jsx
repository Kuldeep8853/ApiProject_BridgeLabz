import React, { Component } from 'react';
import { Button } from 'reactstrap';
import { addEmployee } from '../services/Controller'

export class Registration extends Component {

    constructor(props) {
        super(props);
        this.state = {
            FirstName: '',
            LastName: '',
            PhoneNumber: '',
            Email: '',
            PassWord: ''
        }
    }
    handleFNameChang = (event) => {
        const FirstName = event.target.value;
        this.setState({
            FirstName: FirstName
        });
        console.log("FirstName", this.state.FirstName);
    }

    handleLNameChang = (event) => {
        const LastName = event.target.value;
        this.setState({
            LastName: LastName
        });
        console.log("LastName", this.state.LastName);
    }

    handlePhoneNumberChang = (event) => {
        const PhoneNumber = event.target.value;
        this.setState({
            PhoneNumber: PhoneNumber
        });
        console.log("PhoneNumber", this.state.PhoneNumber);
    }

    handleEmailChang = (event) => {
        const Email = event.target.value;
        this.setState({
            Email: Email
        });
        console.log("Email", this.state.Email);
    }

    handlepasswordChang = (event) => {
        const PassWord = event.target.value;
        this.setState({
            PassWord: PassWord
        })
        console.log("PassWord", this.state.PassWord);
    }

    handleRegister = () => {
        this.setState({
            spinner: true
        })
        var data =
        {
            FirstName: this.state.FirstName,
            LastName: this.state.LastName,
            PhoneNumber: this.state.PhoneNumber,
            Email: this.state.Email,
            PassWord: this.state.PassWord
        }
        console.log("data", data);
        if (data!=='undefined') {
            addEmployee(data).then((response) => {
                this.setState({
                    addItemOpen: true,
                    spinner: false
                })
                console.log("Add new Employee response====>", response);
                alert('You have successfully registered');
                window.location.reload();
            })

                .catch((err) => {
                    console.log("error occured while adding----------", err);
                    alert('Your Registration Failed');
                });
        }
        else{
            alert('Please Enter the data')
        }
    }

    render() {
        return (
            <div className="App">
                <div className="Registration-div"><h2>Registration</h2></div>
                <div className="main-Text-div">
                    <div className="FName-div">
                        <input type="text" className="input-fname-text" placeholder="Enter your first name" onChange={this.handleFNameChang} />
                    </div>
                    <div className="LName-div">
                        <input type="text" className="input-lname-text" placeholder="Enter your last name" onChange={this.handleLNameChang} />
                    </div>
                    <div className="PhoneNumber-div">
                        <input type="text" className="input-PhoneNumber-text" placeholder="Enter your PhoneNumber" onChange={this.handlePhoneNumberChang} />
                    </div>
                    <div className="email-div">
                        <input type="email" className="input-email-text" placeholder="Enter your email" onChange={this.handleEmailChang} />
                    </div>
                    <div className="password-div">
                        <input type="password" className="input-password-text" placeholder="Enter password" onChange={this.handlepasswordChang} />
                    </div>
                    <div className="app-button">
                        <Button onClick={this.handleRegister} className="Submit" block>Register</Button>
                    </div>
                </div>
            </div>
        );
    }
}
export default Registration;