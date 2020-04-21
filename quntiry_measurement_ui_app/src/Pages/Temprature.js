import React from 'react'

export class Temprature extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            temprature: '',
        };
    }
    handleTempChang = (event) => {
        const temprature = event.target.value;
        this.setState({
            temprature: temprature
        });
        console.log("length", this.state.temprature);
    }

    render() {
        return (
            <>
                <div>
                    <input type="number" className="input" onChange={this.handleTempChang} />
                    <select className="SelectItems">
                        <option value="Celcious">Celcious</option>
                        <option value="Fahrenhite">Fahrenhite</option>
                    </select>
                </div>
                <div className="equal">=</div>
                <div>
                    <input type="number" className="input" onChange={this.handleTempChang} />
                    <select className="SelectItems">
                        <option value="Celcious">Celcious</option>
                        <option value="Fahrenhite">Fahrenhite</option>
                    </select>
                </div>
            </>
        )
    }
}
export default Temprature;