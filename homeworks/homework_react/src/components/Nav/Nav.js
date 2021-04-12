 import { render } from "enzyme"
import { NavLink } from "react-router-dom"
import { Header } from "semantic-ui-react"
import { Menu } from "semantic-ui-react"
import React from 'react';

const menuItems = [
    {
        name:'albums',
        position: null,
    },
    {
        name:'photos',
        position: null,
    },
    {
        name:'login',
        position: 'right',
    }
];

class Nav extends React.Component {
    renderMenuItems = (item) => {
        return (
            <Menu.Item
            position = {item.position}
            key = {item.name}
            name = {item.name}
            as = {NavLink}
            to = {`/${item.name}`}
            /> 
           )
    };

 render() {
    return (
        <Menu  tabular>
        <Menu.Item>
        <Header as='h3' icon = 'camera retro' floated = 'right'/>
        </Menu.Item>
        {
            Object.keys(menuItems).map(item => {
                return this.renderMenuItems(menuItems[item])
            })
        }
        </Menu>
    );
 }
}

export default Nav;