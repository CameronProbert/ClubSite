import React, { useState } from 'react';
import { Card, Container, Row } from 'react-bootstrap';
 
import { Asset } from '../util/types';

import { getNavImg } from './requests';

const Nav: React.FC = () => {
    const [navImg, setNavImg] = useState<Asset>();
    let [errorMsg, setErrorMsg] = useState<string>();

    getNavImg()
        .then(img => {
            console.log(img);
            setNavImg(img);
        })
        .catch(error => {
            setErrorMsg(error.response.text);
            console.log(errorMsg);
        });

    return <>
        <Container fluid>
            <Row>
                {navImg &&
                    <Card className='text-center'>
                        <Card.Img src={navImg.url} alt={navImg.description} />
                        <Card.ImgOverlay>
                            <Card.Title className='center-vertical'>Club clubity club club</Card.Title>
                        </Card.ImgOverlay>
                    </Card>
                }
            </Row>
        </Container>
    </>;
};

export default Nav;