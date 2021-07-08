import React, { Component } from 'react';
import './TrafficLight.css';
import './NavMenu.css';
import {getdefault,GetCircle} from '../services/LightService.js'
export class Layout extends Component {

  constructor(props) {
    super(props);
    this.state = {
      circle1: 'red',
      circle2: 'green',
      circle3: 'yellow',

    }
  
  }

  changeColor = async(color,time) =>
  {

    setTimeout(async () => {
      const circle =await GetCircle(color)
      this.setState({color:circle.color})
     this.changeColor(circle.color,circle.time);
    },time* 1000);

  }

 init = async () =>
  {
      const defult =await getdefault()      
      this.setState({color:defult.color})
      //alert( this.state.color);
     this.changeColor(defult.color,defult.time);
    // 

  }
  componentDidMount(){
    this.init();
  }

  render () {
    return (
      <div>
       <div className="flex-container">
        <div  className={(this.state.color ===0 || this.state.color ===1) ? 'Red' : 'TurnedOff' }></div>
        <div  className={(this.state.color ===3||this.state.color ===1) ? 'Yellow' : 'TurnedOff' }></div>
        <div  className={this.state.color ===2 ? 'Green' : 'TurnedOff' }></div>
       </div>
      </div>
    );
  }
}


