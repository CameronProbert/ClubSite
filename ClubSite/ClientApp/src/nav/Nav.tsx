import React, { useState } from 'react';
import { getNavImg } from './requests';
import { Container, Row, Col, Image } from 'react-bootstrap';
import { Asset } from '../util/types';

const Nav: React.FC = () => {
    const [navImg, setNavImg] = useState<Asset>();
    let [errorMsg, setErrorMsg] = useState<string>();

    getNavImg()
        .then(img => {
            setNavImg(img);
        })
        .catch(error => {
            setErrorMsg(error.response.text);
            console.log(errorMsg);
        });

    return <>
        <Container fluid>
            <Row>
                <Col>
                    <Image src={navImg.url} fluid alt={navImg.description}/>
                </Col>
            </Row>
        </Container>
    </>;
}

export default Nav;