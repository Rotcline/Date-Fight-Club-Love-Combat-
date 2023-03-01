from fastapi import FastAPI
import redis


app = FastAPI()

r = redis.Redis(host='localhost', port=6379, db=0)

@app.get("/items/{item_id}")
async def read_item(item_id: int):
    # Use Redis to retrieve data
    item = r.get(f"item:{item_id}")
    return {"item_id": item_id, "item": item}

@app.post("/items/")
async def create_item(item: str):
    # Use Redis to store data
    item_id = r.incr("item_id")
    r.set(f"item:{item_id}", item)
    return {"item_id": item_id}
