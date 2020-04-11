import * as request from 'superagent';

import { Asset } from '../util/types'; 

const url = 'api/asset/nav';

export function getNavImg() : Promise<Asset> {
    return request
        .get(`${url}`)
        .then(res => res.body);
}