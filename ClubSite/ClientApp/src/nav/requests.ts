import * as request from "superagent";
import { Asset } from "../util/types";

const url = 'api/random/hello'

export function getNavImg() : Promise<Asset> {
  return request
    .get(`${url}`)
    .then(res => res.body);
}