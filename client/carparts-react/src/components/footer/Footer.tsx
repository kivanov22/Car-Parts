import React from 'react'
import "./Footer.scss"
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import {
    faArrowRight,
    faLocationPin,
    faPhone,
    faMessage
} from "@fortawesome/free-solid-svg-icons";
import {faFacebook,faTwitter,faLinkedin,faYoutube,faInstagram} from "@fortawesome/free-brands-svg-icons"

const Footer = () => {
  return (
    <div className='footer'>
        <div className='aboutUs'>
        <h3>ABOUT US</h3>
        <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Unde minus nemo vero nostrum? Officia, earum.</p>
        <div className='socials'>
        {/* icons facebook,twitter,linkin */}
        <FontAwesomeIcon icon={faFacebook} className='socialIcons'/>
        <FontAwesomeIcon icon={faTwitter} className='socialIcons'/>
        <FontAwesomeIcon icon={faLinkedin} className='socialIcons'/>
        <FontAwesomeIcon icon={faYoutube} className='socialIcons'/>
        <FontAwesomeIcon icon={faInstagram} className='socialIcons'/>
        </div>
        </div>
        <div className='myAccount'>
        <span>
            <FontAwesomeIcon icon={faArrowRight}/>
            Brand
        </span>
        <span>
            <FontAwesomeIcon icon={faArrowRight}/>
            Affiliate
        </span>
        <span>
            <FontAwesomeIcon icon={faArrowRight}/>
            Site Map
        </span>
        <span>
            <FontAwesomeIcon icon={faArrowRight}/>
            Special
        </span>
        <span>
            <FontAwesomeIcon icon={faArrowRight}/>
            My Account
        </span>
        </div>
        <div className='extras'>
        <span>
            <FontAwesomeIcon icon={faArrowRight}/>
            Privacy Policy
        </span>
        <span>
            <FontAwesomeIcon icon={faArrowRight}/>
            Delivery Information
        </span>
        <span>
            <FontAwesomeIcon icon={faArrowRight}/>
            Brand
        </span>
        <span>
            <FontAwesomeIcon icon={faArrowRight}/>
            Special Products
        </span>
        <span>
            <FontAwesomeIcon icon={faArrowRight}/>
            Sitemap
        </span>
        </div>
        <div className='information'>
        <span>
            <FontAwesomeIcon icon={faArrowRight}/>
            Brand
        </span>
        <span>
            <FontAwesomeIcon icon={faArrowRight}/>
            Affiliate
        </span>
        <span>
            <FontAwesomeIcon icon={faArrowRight}/>
            Site Map
        </span>
        <span>
            <FontAwesomeIcon icon={faArrowRight}/>
            Special
        </span>
        <span>
            <FontAwesomeIcon icon={faArrowRight}/>
            My Account
        </span>
        </div>
        <div className='contact'>
        <span>
            <FontAwesomeIcon icon={faLocationPin}/> {` `}
             Autopath Demo Store, 60, 29th Street, San Francisco, CA 94110, USA
        </span>
        <span>
        <FontAwesomeIcon icon={faPhone}/> {` `}
        (+00) 123-456-789
        </span>
        <span>
        <FontAwesomeIcon icon={faMessage}/> {` `}
        support@company.com
        </span>
        </div>
    </div>
  )
}

export default Footer