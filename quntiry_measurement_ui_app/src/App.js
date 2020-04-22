import React from 'react';
import './App.css';
import { BrowserRouter, Route, Switch, withRouter } from 'react-router-dom';
import Length from './Pages/Length';
import Temprature from './Pages/Temprature';
import Weight from './Pages/Weight';
import { QuantityRow } from './component/QuantityRow';

function App() {
  const Menu = withRouter(QuantityRow);
  return (
    <div className="App">
      <div className="optionColor">
        <h1>Quantity Measurement</h1>
        <BrowserRouter>
        <Menu/>
      <div>
        <Switch>
        <Route path='/Length' component={Length} exact />
        <Route path='/Weight' component={Weight}  />
        <Route path='/Temprature' component={Temprature} />
        </Switch>
      </div>
    </BrowserRouter>  
      </div>
    </div>
  );
}
export default App;