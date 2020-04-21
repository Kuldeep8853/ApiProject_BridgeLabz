import React from 'react'

export class Weight extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            weight: '',
        };
    }
    handleWeightChang = (event) => {
        const weight = event.target.value;
        this.setState({
            weight: weight
        });
        console.log("length", this.state.weight);
    }

    render() {
        return (
            <>
                <div>
                    <input type="number" className="input" onChange={this.handleWeightChang} />
                    <select className="SelectItems">
                        <option value="Kilogram"> Kilogram</option>
                        <option value="Gram"> Gram</option>
                    </select>
                </div>
                <div className="equal">=</div>
                <div>
                    <input type="number" className="input" onChange={this.handleWeightChang} />
                    <select className="SelectItems">
                        <option value="Kilogram"> Kilogram</option>
                        <option value="Gram"> Gram</option>
                    </select>
                </div>
            </>
        )
    }
}
export default Weight;
