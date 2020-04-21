import React from 'react'

export class Length extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            length: '',
        };
    }
    handleLengthChang = (event) => {
        const length = event.target.value;
        this.setState({
            length: length
        });
        console.log("length", this.state.length);
    }

    render() {
        return (
            <>
                <div>
                    <input type="number" className="input" onChange={this.handleLengthChang} />
                    <select className="SelectItems" >
                        <option value="Feet">Feet</option>
                        <option value="Inch"> Inch</option>
                    </select>
                </div>
                <div className="equal">=</div>
                <div>
                    <input type="number" className="input" onChange={this.handleLengthChang} />
                    <select className="SelectItems" >
                        <option value="Feet">Feet</option>
                        <option value="Inch"> Inch</option>
                    </select>
                </div>
            </>
        )
    };
}
export default Length;